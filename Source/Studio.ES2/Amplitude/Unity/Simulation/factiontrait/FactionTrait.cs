using ES2.Amplitude.Unity.Xml;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(FactionAffinity))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlRoot("FactionTrait", Namespace = "", IsNullable = true)]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class FactionTrait : DatatableElement
	{
		private ObservableListSource<Command> commandField;

		private ObservableListSource<XmlNamedReference> outpostImprovementReferenceField;

		private ObservableListSource<XmlNamedReference> colonyImprovementReferenceField;

		private ObservableListSource<XmlNamedReference> subTraitField;

		private ObservableListSource<SimulationDescriptorReference> simulationDescriptorReferenceField;

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
			commandField = new ObservableListSource<Command>();
			outpostImprovementReferenceField = new ObservableListSource<XmlNamedReference>();
			colonyImprovementReferenceField = new ObservableListSource<XmlNamedReference>();
			subTraitField = new ObservableListSource<XmlNamedReference>();
			simulationDescriptorReferenceField = new ObservableListSource<SimulationDescriptorReference>();
			factionTraitTooltipOverrideField = new FactionTraitTooltipOverride();
		}


		/// <remarks/>
		[XmlElement("Command", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<Command> Command
		{
			get { return this.commandField; }
			set
			{
				this.commandField = value;
				this.RaisePropertyChanged("Command");
			}
		}

		/// <remarks/>
		[XmlElement("OutpostImprovementReference", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<XmlNamedReference> OutpostImprovementReference
		{
			get { return this.outpostImprovementReferenceField; }
			set
			{
				this.outpostImprovementReferenceField = value;
				this.RaisePropertyChanged("OutpostImprovementReference");
			}
		}

		/// <remarks/>
		[XmlElement("ColonyImprovementReference", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<XmlNamedReference> ColonyImprovementReference
		{
			get { return this.colonyImprovementReferenceField; }
			set
			{
				this.colonyImprovementReferenceField = value;
				this.RaisePropertyChanged("ColonyImprovementReference");
			}
		}

		/// <remarks/>
		[XmlElement("SubTrait", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<XmlNamedReference> SubTrait
		{
			get { return this.subTraitField; }
			set
			{
				this.subTraitField = value;
				this.RaisePropertyChanged("SubTrait");
			}
		}

		/// <remarks/>
		[XmlElement("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<SimulationDescriptorReference> SimulationDescriptorReference
		{
			get { return this.simulationDescriptorReferenceField; }
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public FactionTraitTooltipOverride FactionTraitTooltipOverride
		{
			get { return this.factionTraitTooltipOverrideField; }
			set
			{
				this.factionTraitTooltipOverrideField = value;
				this.RaisePropertyChanged("FactionTraitTooltipOverride");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Prerequisites
		{
			get { return this.prerequisitesField; }
			set
			{
				this.prerequisitesField = value;
				this.RaisePropertyChanged("Prerequisites");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Cost
		{
			get { return this.costField; }
			set
			{
				this.costField = value;
				this.RaisePropertyChanged("Cost");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Family
		{
			get { return this.familyField; }
			set
			{
				this.familyField = value;
				this.RaisePropertyChanged("Family");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(true)]
		public bool Hidden
		{
			get { return this.hiddenField; }
			set
			{
				this.hiddenField = value;
				this.RaisePropertyChanged("Hidden");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Custom
		{
			get { return this.customField; }
			set
			{
				this.customField = value;
				this.RaisePropertyChanged("Custom");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool HiddenOnFailPrerequisites
		{
			get { return this.hiddenOnFailPrerequisitesField; }
			set
			{
				this.hiddenOnFailPrerequisitesField = value;
				this.RaisePropertyChanged("HiddenOnFailPrerequisites");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool ValidWithAtLeastOnePrerequisite
		{
			get { return this.validWithAtLeastOnePrerequisiteField; }
			set
			{
				this.validWithAtLeastOnePrerequisiteField = value;
				this.RaisePropertyChanged("ValidWithAtLeastOnePrerequisite");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "0")]
		public float Level
		{
			get { return this.levelField; }
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("Level");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Root
		{
			get { return this.rootField; }
			set
			{
				this.rootField = value;
				this.RaisePropertyChanged("Root");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IgnoreForTraitsCount
		{
			get { return this.ignoreForTraitsCountField; }
			set
			{
				this.ignoreForTraitsCountField = value;
				this.RaisePropertyChanged("IgnoreForTraitsCount");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string SubCategory
		{
			get { return this.subCategoryField; }
			set
			{
				this.subCategoryField = value;
				this.RaisePropertyChanged("SubCategory");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string TraitCategory
		{
			get { return this.traitCategoryField; }
			set
			{
				this.traitCategoryField = value;
				this.RaisePropertyChanged("TraitCategory");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string TraitSubCategory
		{
			get { return this.traitSubCategoryField; }
			set
			{
				this.traitSubCategoryField = value;
				this.RaisePropertyChanged("TraitSubCategory");
			}
		}


	}
}
