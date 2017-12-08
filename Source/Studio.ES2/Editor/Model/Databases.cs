using ES2.Amplitude;
using ES2.Amplitude.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace ES2.Editor.Model
{
	public static class Databases
	{
		private static Dictionary<Type, object> databases = new Dictionary<Type, object>();

		public static bool LoadDatabase<T>(string path, XmlAttributeOverride[] overrides = null, XmlExtraType[] extraTypes = null) where T : IDatatableElement
		{
			try
			{
				if (!databases.TryGetValue(typeof(T), out object value))
				{
					Database<T> database = new Database<T>();
					if (database.LoadFile(path, overrides, extraTypes))
					{
						databases.Add(typeof(T), database);
						return true;
					}
				}
				else if ((value as Database<T>).LoadFile(path, overrides, extraTypes))
				{
					return true;
				}
			}
			catch (Exception exception)
			{
				Diagnostics.LogWarning("Exception caught while loading file '{0}' in database of type '{1}'. Exception: {2}", path, typeof(T).ToString(), exception.ToString());
			}
			return false;
		}


	}
}
