using ES2.Amplitude.Xml.Serialization;
using System.Collections.Generic;

namespace ES2.Amplitude.Unity.Framework
{
	public static class Databases
	{
		private static Dictionary<System.Type, object> databases = new Dictionary<System.Type, object>();



		public static bool LoadDatabase<T>(string path, XmlAttributeOverride[] overrides = null, XmlExtraType[] extraTypes = null) where T : IDatatableElement
		{
			try
			{
				if (!databases.TryGetValue(typeof(T), out object obj))
				{
					Database<T> database = new Database<T>();
					if (database.LoadFile(path, overrides, extraTypes))
					{
						databases.Add(typeof(T), database);
						return true;
					}
				}
				else if ((obj as Database<T>).LoadFile(path, overrides, extraTypes))
				{
					return true;
				}
			}
			catch (System.Exception ex)
			{
				Diagnostics.LogWarning("Exception caught while loading file '{0}' in database of type '{1}'. Exception: {2}", path, typeof(T).ToString(), ex.ToString());
			}
			return false;
		}


	}
}
