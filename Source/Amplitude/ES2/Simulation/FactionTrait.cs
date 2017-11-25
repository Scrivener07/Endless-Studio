using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionAffinity))]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class FactionTrait : DatatableElement
	{
		private Command[] commandField;

		private XmlNamedReference[] outpostImprovementReferenceField;

		private XmlNamedReference[] colonyImprovementReferenceField;

		private XmlNamedReference[] subTraitField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private FactionTraitTooltipOverride factionTraitTooltipOverrideField;

		private string prerequisitesField;

		private int costField;

		private string familyField;

		private bool hiddenField;

		private bool customField;

		private bool hiddenOnFailPrerequisitesField;

		private bool validWithAtLeastOnePrerequisiteField;

		private float levelField;

		private string rootField;

		private bool ignoreForTraitsCountField;

		private string subCategoryField;

		private string traitCategoryField;

		private string traitSubCategoryField;

		public FactionTrait()
		{
			this.costField = 0;
			this.hiddenField = true;
			this.customField = false;
			this.hiddenOnFailPrerequisitesField = false;
			this.validWithAtLeastOnePrerequisiteField = false;
			this.levelField = ((float)(0F));
			this.ignoreForTraitsCountField = false;
			this.traitCategoryField = "";
			this.traitSubCategoryField = "";
		}


		[System.Xml.Serialization.XmlElementAttribute("Command", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Command[] Command
		{
			get
			{
				return this.commandField;
			}
			set
			{
				this.commandField = value;
				this.RaisePropertyChanged("Command");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("OutpostImprovementReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] OutpostImprovementReference
		{
			get
			{
				return this.outpostImprovementReferenceField;
			}
			set
			{
				this.outpostImprovementReferenceField = value;
				this.RaisePropertyChanged("OutpostImprovementReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ColonyImprovementReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] ColonyImprovementReference
		{
			get
			{
				return this.colonyImprovementReferenceField;
			}
			set
			{
				this.colonyImprovementReferenceField = value;
				this.RaisePropertyChanged("ColonyImprovementReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("SubTrait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] SubTrait
		{
			get
			{
				return this.subTraitField;
			}
			set
			{
				this.subTraitField = value;
				this.RaisePropertyChanged("SubTrait");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SimulationDescriptorReference
		{
			get
			{
				return this.simulationDescriptorReferenceField;
			}
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public FactionTraitTooltipOverride FactionTraitTooltipOverride
		{
			get
			{
				return this.factionTraitTooltipOverrideField;
			}
			set
			{
				this.factionTraitTooltipOverrideField = value;
				this.RaisePropertyChanged("FactionTraitTooltipOverride");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Prerequisites
		{
			get
			{
				return this.prerequisitesField;
			}
			set
			{
				this.prerequisitesField = value;
				this.RaisePropertyChanged("Prerequisites");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Cost
		{
			get
			{
				return this.costField;
			}
			set
			{
				this.costField = value;
				this.RaisePropertyChanged("Cost");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Family
		{
			get
			{
				return this.familyField;
			}
			set
			{
				this.familyField = value;
				this.RaisePropertyChanged("Family");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool Hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
				this.RaisePropertyChanged("Hidden");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Custom
		{
			get
			{
				return this.customField;
			}
			set
			{
				this.customField = value;
				this.RaisePropertyChanged("Custom");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HiddenOnFailPrerequisites
		{
			get
			{
				return this.hiddenOnFailPrerequisitesField;
			}
			set
			{
				this.hiddenOnFailPrerequisitesField = value;
				this.RaisePropertyChanged("HiddenOnFailPrerequisites");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ValidWithAtLeastOnePrerequisite
		{
			get
			{
				return this.validWithAtLeastOnePrerequisiteField;
			}
			set
			{
				this.validWithAtLeastOnePrerequisiteField = value;
				this.RaisePropertyChanged("ValidWithAtLeastOnePrerequisite");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float Level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("Level");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Root
		{
			get
			{
				return this.rootField;
			}
			set
			{
				this.rootField = value;
				this.RaisePropertyChanged("Root");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IgnoreForTraitsCount
		{
			get
			{
				return this.ignoreForTraitsCountField;
			}
			set
			{
				this.ignoreForTraitsCountField = value;
				this.RaisePropertyChanged("IgnoreForTraitsCount");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SubCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
				this.RaisePropertyChanged("SubCategory");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string TraitCategory
		{
			get
			{
				return this.traitCategoryField;
			}
			set
			{
				this.traitCategoryField = value;
				this.RaisePropertyChanged("TraitCategory");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string TraitSubCategory
		{
			get
			{
				return this.traitSubCategoryField;
			}
			set
			{
				this.traitSubCategoryField = value;
				this.RaisePropertyChanged("TraitSubCategory");
			}
		}
	}


	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class FactionPopulationTrait : FactionTrait
	{

		private XmlNamedReference[] majorPopulationDescriptorsField;

		private XmlNamedReference[] nonMajorPopulationDescriptorsField;

		private XmlNamedReference[] majorPopulationAspirationsField;

		private XmlNamedReference[] nonMajorPopulationsAspirationsField;


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationDescriptors
		{
			get
			{
				return this.majorPopulationDescriptorsField;
			}
			set
			{
				this.majorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("MajorPopulationDescriptors");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationDescriptors
		{
			get
			{
				return this.nonMajorPopulationDescriptorsField;
			}
			set
			{
				this.nonMajorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("NonMajorPopulationDescriptors");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("AspirationReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationAspirations
		{
			get
			{
				return this.majorPopulationAspirationsField;
			}
			set
			{
				this.majorPopulationAspirationsField = value;
				this.RaisePropertyChanged("MajorPopulationAspirations");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("AspirationReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationsAspirations
		{
			get
			{
				return this.nonMajorPopulationsAspirationsField;
			}
			set
			{
				this.nonMajorPopulationsAspirationsField = value;
				this.RaisePropertyChanged("NonMajorPopulationsAspirations");
			}
		}
	}
}