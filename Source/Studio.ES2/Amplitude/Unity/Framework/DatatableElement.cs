using ES2.Amplitude.Unity.Simulation;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Editor.Model
{
	[XmlInclude(typeof(QuestDefinition))]
	[XmlInclude(typeof(TutorialDefinition))]
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(Faction))]
	[XmlInclude(typeof(FactionAffinity))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionTrait))]
	[XmlInclude(typeof(FactionTraitCategoryDefinition))]
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(MajorFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(PirateFaction))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class DatatableElement : EntityType { }

	public interface IDatatableElement
	{
		string Name { get; }
		void PostDeserialization();
	}
}
