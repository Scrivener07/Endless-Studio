using ES2.Editor.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Editor.Model
{
	[XmlRoot("Datatable")]
	public class Datatable : Dictionary<string, EntityType>, IXmlSerializable
	{
		public Datatable() : base(0) { }


		#region IXmlSerializable

		public XmlSchema GetSchema()
		{
			return (null);
		}

		public void WriteXml(XmlWriter xml)
		{
			if (xml == null) throw new ArgumentNullException("xml");

			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add("", "");

			foreach (var kvp in this)
			{
				var key = kvp.Value.GetType().Name;

				if (EntityType.Serializer.ContainsKey(key))
				{
					TypeValue valueType = EntityType.Serializer[key];
					valueType.Serialize(xml, kvp.Value, namespaces);
				}
				else
				{
					throw new Exception("No serializer for the '" + key + "' type.");
				}
			}
		}


		public void ReadXml(XmlReader xml)
		{
			if (xml == null) throw new ArgumentNullException("xml");

			if (xml.LocalName == "Datatable" && xml.NodeType == XmlNodeType.Element)
			{
				while (xml.Read())
				{
					if (xml.Depth == 1 && xml.NodeType == XmlNodeType.Element)
					{
						EntityType element = EntityType.Serializer.Read(xml);
						if (Store(element))
						{
							Trace.WriteLine("Xml Reader: Allocated: " + element.Name);
						}
					}
				}

				Trace.WriteLine("Xml Reader: Done parsing xml file. Got " + Count + " elements");
			}
		}


		#endregion


		private bool Store(EntityType element)
		{
			if (element != null)
			{
				if (!ContainsKey(element.Name))
				{
					Add(element.Name, element);
					return true;
				}
				else
				{
					Trace.WriteLine("Datatable already contains the element " + element.Name + ". Skipping duplicate Element: '" + element.Name + "'");
					return false;
				}
			}
			else
			{
				Trace.WriteLine("Datatable: Cannot allocate a null element.");
				return false;
			}
		}


	}
}
