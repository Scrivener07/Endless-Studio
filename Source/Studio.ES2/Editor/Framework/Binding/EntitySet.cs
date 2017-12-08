using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ES2.Editor.Framework.Binding
{
	/// <summary>
	/// Exposes a DbSet in the current DbContext as a bindable data source.
	/// </summary>
	/// <remarks>
	/// This class implements the IListSource interface and returns an IBindingList built on top of the underlying DbSet.
	/// </remarks>
	public class EntitySet : IListSource, IQueryable
	{
		#region Fields

		EntityDataSource source;        // EntityDataSource that created this set
		IQueryable query;               // the value of the property
		IEntityBindingList entityList;  // default view for this set
		PropertyInfo propertyinfo;      // the property on the object context that gets the objects in this set
		Type elementType;               // the type of object in this set
		ListDictionary lookup;          // lookup dictionary (used to show and edit related entities in grid cells)

		#endregion

		#region Contructor

		/// <summary>
		/// Initializes a new instance of a <see cref="EntitySet"/>.
		/// </summary>
		/// <param name="entityDataSource"><see cref="EntityDataSource"/> that owns the entities.</param>
		/// <param name="propertyInfo"><see cref="PropertyInfo"/> used to retrieve the set from the context.</param>
		internal EntitySet(EntityDataSource entityDataSource, PropertyInfo propertyInfo)
		{
			var type = propertyInfo.PropertyType;
			Debug.Assert(
				type.IsGenericType &&
				type.GetGenericTypeDefinition() == typeof(DbSet<>) &&
				type.GetGenericArguments().Length == 1);

			source = entityDataSource;
			propertyinfo = propertyInfo;
			elementType = type.GetGenericArguments()[0];
		}

		#endregion

		#region Object Model


		/// <summary>
		/// Gets an <see cref="IBindingListView"/> that can be used as a data source for bound controls.
		/// </summary>
		public IBindingListView List { get { return GetBindingList(); } }


		/// <summary>
		/// Gets the <see cref="EntityDataSource"/> that owns this entity set.
		/// </summary>
		public EntityDataSource DataSource { get { return source; } }


		/// <summary>
		/// Gets the name of this entity set.
		/// </summary>
		public string Name { get { return propertyinfo != null ? propertyinfo.Name : null; } }


		/// <summary>
		/// Gets the type of entity in this entity set.
		/// </summary>
		/// <remarks>
		/// Name chosen for consistency with EntitySet.ElementType
		/// (EntityType would seem more appropriate).
		/// </remarks>
		public Type ElementType { get { return elementType; } }


		/// <summary>
		/// Gets the <see cref="IQueryable"/> object that retrieves the entities in this set.
		/// </summary>
		public IQueryable Query
		{
			get
			{
				if (query == null && source.Context != null && propertyinfo != null)
				{
					query = propertyinfo.GetValue(source.Context, null) as IQueryable;
				}
				return query;
			}
		}


		/// <summary>
		/// Gets a list of the entities in the set that have not been deleted or detached.
		/// </summary>
		public IEnumerable ActiveEntities { get { return GetActiveEntities(Query); } }


		/// <summary>
		/// Gets a list of the entities in the set that have not been deleted or detached.
		/// </summary>
		internal static IEnumerable GetActiveEntities(IEnumerable query)
		{
			if (query != null)
			{
				foreach (object item in query)
				{
					var state = item is EntityObject
						? ((EntityObject)item).EntityState
						: EntityState.Unchanged;
					switch (state)
					{
						case EntityState.Deleted:
						case EntityState.Detached:
							break;
						default:
							yield return item;
							break;
					}
				}
			}
		}


		/// <summary>
		/// Cancels any pending changes on this entity set.
		/// </summary>
		internal void CancelChanges()
		{
			if (entityList != null && Query != null)
			{
				var ctx = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)source.Context).ObjectContext;
				ctx.Refresh(RefreshMode.StoreWins, Query);
				entityList.Refresh();
			}
		}


		/// <summary>
		/// Refreshes this set's view by re-loading from the database.
		/// </summary>
		public void RefreshView()
		{
			if (entityList != null && Query != null)
			{
				var context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)source.Context).ObjectContext;
				context.Refresh(RefreshMode.ClientWins, Query);
				entityList.Refresh();
			}
		}


		/// <summary>
		/// Gets a dictionary containing entities as keys and their string representation as values.
		/// </summary>
		/// <remarks>
		/// The data map is useful for displaying and editing entities in grid cells.
		/// </remarks>
		public ListDictionary LookupDictionary
		{
			get
			{
				if (lookup == null)
				{
					lookup = BuildLookupDictionary();
				}
				return lookup;
			}
		}

		#endregion

		#region Implementation

		// gets an IBindingListView for this entity set
		IBindingListView GetBindingList()
		{
			if (entityList == null)
			{
				// create the list
				var listType = typeof(EntityBindingList<>);
				listType = listType.MakeGenericType(this.ElementType);
				entityList = (IEntityBindingList)Activator.CreateInstance(listType, source, this.Query, Guid.NewGuid().ToString());// this.Name);

				// and listen to changes in the new list
				entityList.ListChanged += _list_ListChanged;
			}
			return entityList;
		}



		// update data map when list changes
		void _list_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (lookup != null)
			{
				// clear old dictionary
				lookup.Clear();

				// build new dictionary
				var map = BuildLookupDictionary(entityList);
				foreach (var kvp in map)
				{
					lookup.Add(kvp.Key, kvp.Value);
				}
			}
		}


		// build a data map for this entity set
		ListDictionary BuildLookupDictionary()
		{
			return BuildLookupDictionary(ActiveEntities);
		}


		ListDictionary BuildLookupDictionary(IEnumerable entities)
		{
			// if the entity implements "ToString", then use it
			var mi = elementType.GetMethod("ToString");
			if (mi != null && mi.DeclaringType == elementType)
			{
				var list = new List<KVPair>();
				foreach (object item in entities)
				{
					list.Add(new KVPair(item, item.ToString()));
				}
				return BuildLookupDictionary(list);
			}

			// use "DefaultProperty"
			var atts = elementType.GetCustomAttributes(typeof(DefaultPropertyAttribute), false);
			if (atts != null && atts.Length > 0)
			{
				var dpa = atts[0] as DefaultPropertyAttribute;
				var pi = elementType.GetProperty(dpa.Name);
				if (pi != null && pi.PropertyType == typeof(string))
				{
					var list = new List<KVPair>();
					foreach (object item in entities)
					{
						list.Add(new KVPair(item, (string)pi.GetValue(item, null)));
					}
					return BuildLookupDictionary(list);
				}
			}

			// no default property: look for properties of type string with 
			// names that contain "Name" or "Description"
			foreach (var pi in elementType.GetProperties())
			{
				if (pi.PropertyType == typeof(string))
				{
					if (pi.Name.IndexOf("Name", StringComparison.OrdinalIgnoreCase) > -1 ||
						pi.Name.IndexOf("Description", StringComparison.OrdinalIgnoreCase) > -1)
					{
						var list = new List<KVPair>();
						foreach (object item in entities)
						{
							list.Add(new KVPair(item, (string)pi.GetValue(item, null)));
						}
						return BuildLookupDictionary(list);
					}
				}
			}

			// no dice
			return null;
		}


		ListDictionary BuildLookupDictionary(List<KVPair> list)
		{
			// sort list display value
			list.Sort();

			// create data map
			var map = new ListDictionary();
			foreach (var kvp in list)
			{
				map.Add(kvp.Key, kvp.Value);
			}

			// done
			return map;
		}


		class KVPair : IComparable
		{
			public object Key { get; set; }
			public string Value { get; set; }

			public KVPair(object key, string value)
			{
				Key = key;
				Value = value;
			}

			int IComparable.CompareTo(object obj)
			{
				return string.Compare(this.Value, ((KVPair)obj).Value, StringComparison.OrdinalIgnoreCase);
			}
		}

		#endregion

		#region IListSource

		bool IListSource.ContainsListCollection { get { return false; } }

		IList IListSource.GetList()
		{
			return GetBindingList();
		}

		#endregion

		#region IQueryable

		Type IQueryable.ElementType { get { return elementType; } }

		Expression IQueryable.Expression { get { return Query.Expression; } }

		IQueryProvider IQueryable.Provider { get { return Query.Provider; } }


		IEnumerator IEnumerable.GetEnumerator()
		{
			return Query.GetEnumerator();
		}

		#endregion
	}
}
