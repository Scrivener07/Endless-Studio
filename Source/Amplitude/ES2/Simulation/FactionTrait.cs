using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionAffinity))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
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


		[XmlElement("Command", Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement("OutpostImprovementReference", Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement("ColonyImprovementReference", Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement("SubTrait", Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
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


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
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


		[XmlAttribute]
		[DefaultValue(0)]
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


		[XmlAttribute]
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


		[XmlAttribute]
		[DefaultValue(true)]
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


		[XmlAttribute]
		[DefaultValue(false)]
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


		[XmlAttribute]
		[DefaultValue(false)]
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


		[XmlAttribute]
		[DefaultValue(false)]
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


		[XmlAttribute]
		[DefaultValue(typeof(float), "0")]
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


		[XmlAttribute]
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


		[XmlAttribute]
		[DefaultValue(false)]
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


		[XmlAttribute]
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


		[XmlAttribute]
		[DefaultValue("")]
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


		[XmlAttribute]
		[DefaultValue("")]
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
}