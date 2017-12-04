using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES2.Amplitude.Xml.Serialization;

namespace ES2.Amplitude.Unity.Framework
{
	public static class Databases
	{
		private static Dictionary<System.Type, object> databases = new Dictionary<System.Type, object>();



		public static bool LoadDatabase<T>(string path, XmlAttributeOverride[] overrides = null, XmlExtraType[] extraTypes = null) where T : IDatatableElement
		{
			try
			{
				object obj;
				if (!Databases.databases.TryGetValue(typeof(T), out obj))
				{
					Database<T> database = new Database<T>();
					if (database.LoadFile(path, overrides, extraTypes))
					{
						Databases.databases.Add(typeof(T), (object)database);
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
				Diagnostics.LogWarning("Exception caught while loading file '{0}' in database of type '{1}'. Exception: {2}", (object)path, (object)typeof(T).ToString(), (object)ex.ToString());
			}
			return false;
		}


	}
}
