using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Diagnostics;

namespace Studio.Framework.Sources
{
	/// <summary>
	/// Extends the IBindingListView with properties and methods relative to the entity set.
	/// </summary>
	public interface IEntityBindingList : IBindingListView
	{
		/// <summary>
		/// Gets the <see cref="EntityDataSource"/> that owns the elements on this list.
		/// </summary>
		EntityDataSource DataSource { get; }

		/// <summary>
		/// Gets the type of element on this list.
		/// </summary>
		Type ElementType { get; }

		/// <summary>
		/// Refresh the list by re-loading all items from the source query.
		/// </summary>
		void Refresh();
	}


	/// <summary>
	/// IBindingList with support for sorting.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class EntityBindingList<T> : BindingList<T>, ITypedList, IBindingListView, IEntityBindingList where T : class
	{

		#region Fields

		EntityDataSource _ds;
		DbSet<T> _set;
		EntityCollection<T> _coll;
		IEnumerable _query;
		string _name;
		PropertyDescriptor _sortProp;
		ListSortDirection _sortDir;
		bool _deferNotifications;
		int _addingNew;

		#endregion


		#region Constructor

		/// <summary>
		/// Initializes a new instance of a <see cref="EntityBindingList"/>.
		/// </summary>
		/// <param name="dataSource"><see cref="EntityDataSource"/> that owns the entities on this list.</param>
		/// <param name="query"><see cref="IEnumerable"/> that provides the entities for this list.</param>
		/// <param name="name">A name for identifying this list in its parent (for hierarchical binding).</param>
		public EntityBindingList(EntityDataSource dataSource, IEnumerable query, string name)
		{
			_ds = dataSource;
			_set = query as DbSet<T>;
			_coll = query as EntityCollection<T>;
			_query = query;
			_name = name;

			// populate list
			if (dataSource != null && !dataSource.DesignMode)
			{
				// at run time, get the data
				Refresh();
			}
			else
			{
				// at design time, add one element to help with binding
				try
				{
					AddNew();
				}
				catch { }
			}
		}


		/// <summary>
		/// Initializes a new instance of a <see cref="EntityBindingList"/>.
		/// </summary>
		/// <param name="query"><see cref="IEnumerable"/> that provides the entities for this list.</param>
		public EntityBindingList(IEnumerable query) : this(null, query, string.Empty)
		{
			// method
		}

		#endregion


		#region Object Model

		/// <summary>
		/// Gets the <see cref="EntityDataSource"/> that owns the elements on this list.
		/// </summary>
		public EntityDataSource DataSource
		{
			get { return _ds; }
		}
		/// <summary>
		/// Gets the <see cref="Type"/> of elements on this list.
		/// </summary>
		public Type ElementType
		{
			get { return typeof(T); }
		}
		/// <summary>
		/// Refreshes the list by re-loading all items from the source query.
		/// </summary>
		public void Refresh()
		{
			try
			{
				// suspend notifications until done
				_deferNotifications = true;

				// clear current items
				Clear();

				// add items in the query
				foreach (T item in EntitySet.GetActiveEntities(_query))
				{
					if (ApplyFilter(item))
					{
						this.Add(item);
					}
				}

				// apply sort if any
				if (IsSortedCore)
				{
					ApplySortCore(_sortProp, _sortDir);
				}
			}
			finally
			{
				// done
				_deferNotifications = false;
				OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
		}

		#endregion


		#region Overrides

		/// <summary>
		/// Raises the <see cref="ListChanged"/> event.
		/// </summary>
		/// <param name="e"><see cref="ListChangedEventArgs"/> that contains the event data.</param>
		protected override void OnListChanged(ListChangedEventArgs e)
		{
			if (!_deferNotifications)
			{
				base.OnListChanged(e);

				// refresh iff we are not adding a new item
				if (_addingNew == 0)
				{
					if (e.ListChangedType == ListChangedType.ItemChanged ||
						e.ListChangedType == ListChangedType.ItemAdded)
					{
						// refresh list (to honor filters)
						if (_set == null && _query != null)
						{
							Refresh();
						}

						// refresh sort
						if (_sortProp != null && e.PropertyDescriptor == _sortProp)
						{
							ApplySortCore(_sortProp, _sortDir);
						}
					}
				}
			}
		}
		/// <summary>
		/// Adds a new item to the end of the collection.
		/// </summary>
		/// <returns>The item that was added to the collection.</returns>
		protected override object AddNewCore()
		{
			// create new object
			var newObject = base.AddNewCore() as T;

			// add to entity set
			if (_set != null)
			{
				_set.Add(newObject);
			}
			else if (_coll != null)
			{
				_coll.Add(newObject);
			}

			// and return the new object
			return newObject;
		}
		/// <summary>
		/// Removes the item at the specified index.
		/// </summary>
		/// <param name="index">Index of the item to remove.</param>
		protected override void RemoveItem(int index)
		{
			// remove from entity set
			if (index > -1)
			{
				T item = this[index] as T;

				if (_set != null)
				{
					_set.Remove(item);

					// check that the entity was deleted
					var ent = item as EntityObject;
					if (ent != null)
					{
						Debug.Assert(
							ent.EntityState == EntityState.Deleted ||
							ent.EntityState == EntityState.Detached
							);
					}
				}
				else if (_coll != null)
				{
					_coll.Remove(item);
				}
			}

			// and remove from this list
			base.RemoveItem(index);
		}
		/// <summary>
		/// Allow adding new only if we have a set.
		/// </summary>
		bool IBindingList.AllowNew
		{
			get { return _set != null || _coll != null; }
		}
		/// <summary>
		/// Allow removing only if we have a set.
		/// </summary>
		bool IBindingList.AllowRemove
		{
			get { return _set != null || _coll != null; }
		}
		protected override void OnAddingNew(AddingNewEventArgs e)
		{
			// BindingList<T> weirdness: EndNew is called twice instead of once
			_addingNew = 2;
			base.OnAddingNew(e);
		}
		public override void CancelNew(int itemIndex)
		{
			base.CancelNew(itemIndex);
			if (itemIndex > -1)
			{
				_addingNew--;
			}
		}
		public override void EndNew(int itemIndex)
		{
			base.EndNew(itemIndex);
			if (itemIndex > -1)
			{
				_addingNew--;
				if (_addingNew == 0 && _sortProp != null)
				{
					ApplySortCore(_sortProp, _sortDir);
				}
			}
		}

		#endregion


		#region Sorting Support

		/// <summary>
		/// Gets a value indicating whether this list supports sorting.
		/// </summary>
		protected override bool SupportsSortingCore
		{
			get { return true; }
		}
		/// <summary>
		/// Gets the <see cref="PropertyDescriptor"/> that is used for sorting the list.
		/// </summary>
		protected override PropertyDescriptor SortPropertyCore
		{
			get { return _sortProp; }
		}
		/// <summary>
		/// Gets the <see cref="ListSortDirection"/> that is used for sorting the list.
		/// </summary>
		protected override ListSortDirection SortDirectionCore
		{
			get { return _sortDir; }
		}
		/// <summary>
		/// Gets a value indicating whether the list is currently sorted.
		/// </summary>
		protected override bool IsSortedCore
		{
			get { return _sortProp != null; }
		}
		/// <summary>
		/// Removes any sorting currently applied to the list.
		/// </summary>
		protected override void RemoveSortCore()
		{
			_sortProp = null;
			Refresh();
		}
		/// <summary>
		/// Sorts the items on the list.
		/// </summary>
		/// <param name="prop"><see cref="PropertyDescriptor"/> that specifies the property to sort on.</param>
		/// <param name="direction"><see cref="ListSortDirection"/> that specifies whether to sort the list in ascending or descending order.</param>
		protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			// get list to sort
			var items = this.Items as List<T>;

			// apply the sort
			if (items != null && prop != null)
			{
				// if this property is an EntityObject, get map to sort by display value
				ListDictionary map = null;
				if (DataSource != null && !prop.PropertyType.IsPrimitive) //typeof(EntityObject).IsAssignableFrom(prop.PropertyType))
				{
					map = DataSource.GetLookupDictionary(prop.PropertyType);
				}

				// go sort the list
				var pc = new PropertyComparer<T>(prop, direction, map);
				items.Sort(pc);
			}

			// save new settings and notify listeners
			_sortProp = prop;
			_sortDir = direction;
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		// PropertyComparer (used to sort the list)
		class PropertyComparer<TC> : IComparer<TC>
		{
			PropertyDescriptor _pd;
			ListSortDirection _direction;
			ListDictionary _map;

			public PropertyComparer(PropertyDescriptor pd, ListSortDirection direction, ListDictionary map)
			{
				_pd = pd;
				_direction = direction;
				_map = map;
			}
			public int Compare(TC x, TC y)
			{
				try
				{
					// get values to compare
					object o1 = _pd.GetValue(x);
					object o2 = _pd.GetValue(y);

					// honor mapping (to sort mapped columns by display value)
					if (_map != null)
					{
						// use mapped values
						o1 = _map[o1.ToString()];
						o2 = _map[o2.ToString()];
					}

					// make sure values are comparable
					var v1 = o1 as IComparable;
					var v2 = o2 as IComparable;

					// make the comparison
					int cmp =
						v1 == null && v2 == null ? 0 :
						v1 == null ? +1 :
						v2 == null ? -1 :
						v1.CompareTo(v2);

					// and honor sort direction
					return _direction == ListSortDirection.Ascending ? +cmp : -cmp;
				}
				catch
				{
					Debug.Assert(false, "comparison failed?");
					return 0; // comparison failed...
				}
			}
		}

		#endregion


		#region ITypedList

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			var list = new List<PropertyDescriptor>();
			foreach (PropertyDescriptor pd in TypeDescriptor.GetProperties(typeof(T)))
			{
				// skip base class properties (EntityState and EntityKey)
				if (pd.ComponentType == typeof(EntityObject))
				{
					continue;
				}

				// add collection properties
				var type = pd.PropertyType;
				if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
				//if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(EntityCollection<>))
				{
					list.Add(new CollectionPropertyDescriptor(DataSource, pd));
					continue;
				}

				// add regular properties
				list.Add(pd);
			}
			return new PropertyDescriptorCollection(list.ToArray());
		}

		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return _name;
		}

		#endregion


		#region IBindingListView

		string _filter;
		DataTable _dtFilter;

		void IBindingListView.ApplySort(ListSortDescriptionCollection sorts)
		{
			throw new NotImplementedException();
		}

		string IBindingListView.Filter
		{
			get { return _filter; }
			set
			{
				_filter = value;
				UpdateFilterTable();
				Refresh();
			}
		}

		void IBindingListView.RemoveFilter()
		{
			_filter = null;
			Refresh();
		}

		ListSortDescriptionCollection IBindingListView.SortDescriptions
		{
			get { return null; }
		}

		bool IBindingListView.SupportsAdvancedSorting
		{
			get { return false; }
		}

		bool IBindingListView.SupportsFiltering
		{
			get { return true; }
		}

		bool ApplyFilter(T item)
		{
			bool pass = true;
			if (_dtFilter != null)
			{
				try
				{
					// populate the row
					var row = _dtFilter.Rows[0];
					foreach (var pi in typeof(T).GetProperties())
					{
						row[pi.Name] = pi.GetValue(item, null);
					}

					// compute the expression
					pass = (bool)row["_filter"];
				}
				catch { }
			}
			return pass;
		}

		void UpdateFilterTable()
		{
			_dtFilter = null;
			if (!string.IsNullOrEmpty(_filter))
			{
				// build/rebuild data table
				var dt = new DataTable();
				foreach (var pi in typeof(T).GetProperties())
				{
					var type = pi.PropertyType;
					var nt = Nullable.GetUnderlyingType(type);
					if (nt != null)
					{
						type = nt;
					}
					dt.Columns.Add(pi.Name, type);
				}

				// add calculated column that contains the filter
				dt.Columns.Add("_filter", typeof(bool), _filter);

				// create a single row for evaluating expressions
				if (dt.Rows.Count == 0)
				{
					dt.Rows.Add(dt.NewRow());
				}

				// done, save table
				_dtFilter = dt;
			}
		}

		#endregion
	}


	// property descriptor that converts EntityCollection<T> properties into
	// EntityBindingList properties.
	class CollectionPropertyDescriptor : PropertyDescriptor
	{
		EntityDataSource _ds;
		PropertyDescriptor _pd;
		Type _listType;

		public CollectionPropertyDescriptor(EntityDataSource ds, PropertyDescriptor pd) : base(pd.Name, null)
		{
			_ds = ds;
			_pd = pd;
			var elementType = _pd.PropertyType.GetGenericArguments()[0];
			_listType = typeof(EntityBindingList<>);
			_listType = _listType.MakeGenericType(elementType);
		}
		public override string Name
		{
			get { return _pd.Name; }
		}
		public override bool IsReadOnly
		{
			get { return _pd.IsReadOnly; }
		}
		public override void ResetValue(object component)
		{
			_pd.ResetValue(component);
		}
		public override bool CanResetValue(object component)
		{
			return _pd.CanResetValue(component);
		}
		public override bool ShouldSerializeValue(object component)
		{
			return _pd.ShouldSerializeValue(component);
		}
		public override Type ComponentType
		{
			get { return _pd.ComponentType; }
		}
		public override Type PropertyType
		{
			get { return _listType; }
		}
		public override object GetValue(object component)
		{
			return Activator.CreateInstance(_listType, _ds, (IEnumerable)_pd.GetValue(component), Name);
		}
		public override void SetValue(object component, object value)
		{
			_pd.SetValue(component, value);
			OnValueChanged(component, EventArgs.Empty);
		}
	}

}
