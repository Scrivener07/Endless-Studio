using ES2.Editor.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace ES2.Editor.Serialization
{
	/// <summary>
	/// A dictionary that stores additional information about a class type that can be used for xml serialization.
	/// </summary>
	public class TypeDictionary : Dictionary<string, TypeValue>
	{

		public void Initialize(Type type)
		{
			var valueType = new TypeValue(type);
			if (!ContainsKey(valueType.Key))
			{
				Add(valueType.Key, valueType);
			}
		}


		public EntityType Read(XmlReader xml)
		{
			if (ContainsKey(xml.Name))
			{
				TypeValue typeVaue = this[xml.Name];
				return (EntityType)typeVaue.Deserialize(xml);
			}

			Trace.WriteLine("Element cache has no serializer for " + xml.Name + "'. Skipping..");
			return null;
		}


	}
}
