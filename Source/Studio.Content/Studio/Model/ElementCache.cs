using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace Studio.Model
{
	public class ElementCache : Dictionary<string, GameType>
	{

		public void Store(Type type)
		{
			string typeName = type.Name;

			if (!this.ContainsKey(typeName))
			{
				this.Add(typeName, new GameType(type));
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
