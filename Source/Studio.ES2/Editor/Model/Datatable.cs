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

			XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
			ns.Add("", "");

			foreach (var kvp in this)
			{
				var key = kvp.Value.GetType().Name;

				if (EntityType.Serializer.ContainsKey(key))
				{
					GameType gametype = EntityType.Serializer[key];
					gametype.Serializer.Serialize(xml, kvp.Value, ns);
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
				if (!this.ContainsKey(element.Name))
				{
					this.Add(element.Name, element);
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
