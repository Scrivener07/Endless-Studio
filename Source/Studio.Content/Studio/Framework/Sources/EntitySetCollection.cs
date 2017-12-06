using System.Collections.ObjectModel;

namespace Studio.Framework.Sources
{
	/// <summary>
	/// Collection of EntitySet objects.
	/// </summary>
	public class EntitySetCollection : ObservableCollection<EntitySet>
	{
		public EntitySet this[string name]
		{
			get
			{
				var index = this.IndexOf(name);
				return index > -1 ? this[index] : null;
			}
		}


		public bool Contains(string name)
		{
			return IndexOf(name) > -1;
		}


		public int IndexOf(string name)
		{
			for (int i = 0; i < Count; i++)
			{
				if (this[i].Name == name)
					return i;
			}
			return -1;
		}
	}

}
