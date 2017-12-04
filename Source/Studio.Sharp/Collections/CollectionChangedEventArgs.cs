using System;

namespace Sharp.Collections
{
	public class CollectionChangedEventArgs<T> : EventArgs
	{
		public readonly int Index;
		public readonly ChangeAction Action;
		public readonly T Item;
		public readonly T Changed;


		public CollectionChangedEventArgs(int index, ChangeAction action, T item, T change)
		{
			Index = index;
			Action = action;
			Item = item;
			Changed = change;
		}
	}


	public enum ChangeAction
	{
		Added,
		Removed,
		Replaced,
		Cleared
	};
}
