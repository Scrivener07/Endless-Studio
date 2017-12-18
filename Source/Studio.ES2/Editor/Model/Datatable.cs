using ES2.Amplitude.Unity.Localization;
using ES2.Amplitude.Unity.Runtime;
using ES2.Amplitude.Unity.Simulation;
using ES2.Editor.Assets;
using ES2.Editor.Model.Serialization;
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
		[XmlIgnore]
		public TableFile Asset { get; set; }


		public Datatable() : base(0) { }


		#region Types

		/// <summary>
		/// Each entity must store its type within the types dictionary. 
		/// </summary>
		private static TypeDictionary Types;

		/// <summary>
		/// Initializes the datatable type dictionary. Called during application startup.
		/// </summary>
		public static void Initialize()
		{
			Types = new TypeDictionary();
			Types.Initialize(typeof(RuntimeModule));
			Types.Initialize(typeof(QuestDefinition));
			Types.Initialize(typeof(TutorialDefinition));
			Types.Initialize(typeof(BasicFaction));
			Types.Initialize(typeof(FactionAffinity));
			Types.Initialize(typeof(FactionAffinityMapping));
			Types.Initialize(typeof(FactionPopulationTrait));
			Types.Initialize(typeof(FactionTrait));
			Types.Initialize(typeof(FactionTraitCategoryDefinition));
			Types.Initialize(typeof(FactionTraitStartingSenate));
			Types.Initialize(typeof(LesserFaction));
			Types.Initialize(typeof(MajorFaction));
			Types.Initialize(typeof(MinorFaction));
			Types.Initialize(typeof(PirateFaction));
			Types.Initialize(typeof(LocalizationDatatableElement));
		}

		#endregion


		#region IXmlSerializable

		public XmlSchema GetSchema() { return (null); }


		public void WriteXml(XmlWriter xml)
		{
			if (xml == null) throw new ArgumentNullException("xml");

			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add("", "");

			foreach (var kvp in this)
			{
				var key = kvp.Value.GetType().Name;
				if (Types.ContainsKey(key))
				{
					TypeValue valueType = Types[key];
					valueType.Serialize(xml, kvp.Value, namespaces);
				}
				else
				{
					throw new KeyNotFoundException("No serializer key for the '" + key + "' type.");
				}
			}
		}

		/// <summary>
		/// TODO: Add support for Xml comments.
		/// </summary>
		/// <param name="xml"></param>
		public void ReadXml(XmlReader xml)
		{
			if (xml == null) throw new ArgumentNullException("xml");

			if (xml.LocalName == "Datatable" && xml.NodeType == XmlNodeType.Element)
			{
				while (xml.Read())
				{
					if (xml.Depth == 1 && xml.NodeType == XmlNodeType.Element)
					{
						EntityType element = Types.Read(xml);
						if (element != null)
						{
							if (!ContainsKey(element.Name))
							{
								Add(element.Name, element);
								Trace.WriteLine("Xml Reader: Allocated: " + element.Name);
							}
							else
							{
								Trace.WriteLine("Datatable already contains the element " + element.Name + ". Skipping duplicate Element: '" + element.Name + "'");
							}
						}
						else
						{
							Trace.WriteLine("Datatable: Cannot allocate a null element.");
						}
					}
				}

				Trace.WriteLine("Xml Reader: Done parsing xml file. Got " + Count + " elements");
			}
		}


		#endregion


	}
}
