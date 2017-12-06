using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Sharp.Collections
{
	public class KeyedObjectCollection<T> : KeyedCollection<string, T> where T : IKeyed
	{
		public delegate void EventHandler();
		public event EventHandler<CollectionChangedEventArgs<T>> CollectionChanged;
		public bool HasData { get { return Count > 0; } }


		public KeyedObjectCollection() : base(null, 0)
		{
			// construct
		}


		protected virtual void OnCollectionChanged(CollectionChangedEventArgs<T> e)
		{
			if (e.Action == ChangeAction.Added)
			{
				if (e.Item != null)
				{
					Trace.WriteLine("Added " + e.Item.KeyName.ToString());
				}
			}

			if (e.Action == ChangeAction.Removed)
			{
				if (e.Item != null)
				{
					Trace.WriteLine("Removed " + e.Item.KeyName.ToString());
				}
			}


			EventHandler<CollectionChangedEventArgs<T>> handler = CollectionChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}

		#region KeyedCollection

		protected override string GetKeyForItem(T item)
		{
			return item.KeyName;
		}


		protected override void InsertItem(int index, T item)
		{
			base.InsertItem(index, item);

			var k = new CollectionChangedEventArgs<T>(index, ChangeAction.Added, item, default(T));

			OnCollectionChanged(k);
		}


		protected override void SetItem(int index, T item)
		{
			T replaced = Items[index];
			base.SetItem(index, item);
			OnCollectionChanged(new CollectionChangedEventArgs<T>(index, ChangeAction.Replaced, replaced, item));
		}


		protected override void RemoveItem(int index)
		{
			T removedItem = Items[index];
			base.RemoveItem(index);
			OnCollectionChanged(new CollectionChangedEventArgs<T>(index, ChangeAction.Removed, removedItem, default(T)));
		}


		protected override void ClearItems()
		{
			base.ClearItems();
			OnCollectionChanged(new CollectionChangedEventArgs<T>(-1, ChangeAction.Cleared, default(T), default(T)));
		}

		#endregion

	}
}
