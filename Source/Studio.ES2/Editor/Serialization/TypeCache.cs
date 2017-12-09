using ES2.Editor.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace ES2.Editor.Serialization
{
	public class TypeCache : Dictionary<string, GameType>
	{

		public void Store(Type type)
		{
			string typeName = type.Name;

			if (!ContainsKey(typeName))
			{
				Add(typeName, new GameType(type));
			}
		}


		public EntityType Read(XmlReader xml)
		{
			var xmlName = xml.Name;

			if (this.ContainsKey(xmlName))
			{
				GameType gametype = this[xmlName];
				return (EntityType)gametype.Serializer.Deserialize(xml);
			}

			Trace.WriteLine("Element cache has no serializer for " + xmlName + "'. Skipping..");
			return null;
		}


	}
}
