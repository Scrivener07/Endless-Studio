﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(UnlockDatatableElement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(HullDefinition))]
	[XmlInclude(typeof(BailiffDefinition))]
	[XmlInclude(typeof(GuiResourcePropertySet))]
	[XmlInclude(typeof(GuiPlanetTypeBaseStats))]
	[XmlInclude(typeof(GuiPlanetStatsModifier))]
	[XmlInclude(typeof(GuiHighlightDefinition))]
	[XmlInclude(typeof(GuiCursor))]
	[XmlInclude(typeof(RankPattern))]
	[XmlInclude(typeof(Rank))]
	[XmlInclude(typeof(PopulationTrait))]
	[XmlInclude(typeof(PopulationCollectionBonusTrait))]
	[XmlInclude(typeof(PopulationModifiersTrait))]
	[XmlInclude(typeof(PopulationPoliticalTraitDefinition))]
	[XmlInclude(typeof(CostReduction))]
	[XmlInclude(typeof(Droplist))]
	[XmlInclude(typeof(UnlockDatatableElement))]
	[XmlInclude(typeof(ConstructibleElement))]
	[XmlInclude(typeof(AnomalyReductionDefinition))]
	[XmlInclude(typeof(AnomalyDefinition))]
	[XmlInclude(typeof(FactionTrait))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionAffinity))]
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlInclude(typeof(Faction))]
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(MajorFaction))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionTraitCategoryDefinition))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class DatatableElement : INotifyPropertyChanged
	{
		private string nameField;


		[XmlAttribute]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
