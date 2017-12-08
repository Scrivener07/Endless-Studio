using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ES2.Editor.Framework.Binding
{
	/// <summary>
	/// Dictionary that implements IListSource (used for implementing lookup dictionaries)
	/// </summary>
	public class ListDictionary : Dictionary<object, string>, IListSource
	{
		public bool ContainsListCollection
		{
			get { throw new NotImplementedException(); }
		}

		public IList GetList()
		{
			var list = new List<KeyValuePair<object, string>>();
			foreach (var item in this)
			{
				list.Add(item);
			}
			return list;
		}
	}
}
