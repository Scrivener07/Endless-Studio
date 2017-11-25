using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[XmlInclude(typeof(BasicFaction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PirateFaction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(LesserFaction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MinorFaction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MajorFaction))]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class Faction : DatatableElement
	{

		private XmlNamedReference affinityField;

		private XmlNamedReference[] traitField;

		private FactionTraitStartingSenate traitStartingSenateField;

		private XmlNamedReference[] bailiffField;

		private StartingPopulation majorPopulationField;

		private StartingPopulation[] minorPopulationField;

		private string localizedDescriptionField;

		private string localizedNameField;

		private string authorField;

		private bool hiddenField;

		private bool standardField;

		private short priorityField;

		public Faction()
		{
			this.authorField = "";
			this.hiddenField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Affinity
		{
			get
			{
				return this.affinityField;
			}
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Trait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] Trait
		{
			get
			{
				return this.traitField;
			}
			set
			{
				this.traitField = value;
				this.RaisePropertyChanged("Trait");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public FactionTraitStartingSenate TraitStartingSenate
		{
			get
			{
				return this.traitStartingSenateField;
			}
			set
			{
				this.traitStartingSenateField = value;
				this.RaisePropertyChanged("TraitStartingSenate");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Bailiff", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] Bailiff
		{
			get
			{
				return this.bailiffField;
			}
			set
			{
				this.bailiffField = value;
				this.RaisePropertyChanged("Bailiff");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StartingPopulation MajorPopulation
		{
			get
			{
				return this.majorPopulationField;
			}
			set
			{
				this.majorPopulationField = value;
				this.RaisePropertyChanged("MajorPopulation");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("MinorPopulation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StartingPopulation[] MinorPopulation
		{
			get
			{
				return this.minorPopulationField;
			}
			set
			{
				this.minorPopulationField = value;
				this.RaisePropertyChanged("MinorPopulation");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string LocalizedDescription
		{
			get
			{
				return this.localizedDescriptionField;
			}
			set
			{
				this.localizedDescriptionField = value;
				this.RaisePropertyChanged("LocalizedDescription");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string LocalizedName
		{
			get
			{
				return this.localizedNameField;
			}
			set
			{
				this.localizedNameField = value;
				this.RaisePropertyChanged("LocalizedName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string Author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
				this.RaisePropertyChanged("Author");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
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
		public bool Standard
		{
			get
			{
				return this.standardField;
			}
			set
			{
				this.standardField = value;
				this.RaisePropertyChanged("Standard");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public short Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}
	}


	[GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[SerializableAttribute()]
	[DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class ColonizablePlanetType : object, INotifyPropertyChanged
	{
		private string typeField;

		private int priorityField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class StartingPopulation : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string affinityField;

		private int countField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Affinity
		{
			get
			{
				return this.affinityField;
			}
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[SerializableAttribute]
	[DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class FactionTraitStartingSenate : FactionTrait
	{

		private XmlNamedReference governmentField;

		private PoliticsWeight[] politicsWeightField;

		private int priorityField;

		public FactionTraitStartingSenate()
		{
			this.priorityField = 0;
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Government
		{
			get
			{
				return this.governmentField;
			}
			set
			{
				this.governmentField = value;
				this.RaisePropertyChanged("Government");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("PoliticsWeight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PoliticsWeight[] PoliticsWeight
		{
			get
			{
				return this.politicsWeightField;
			}
			set
			{
				this.politicsWeightField = value;
				this.RaisePropertyChanged("PoliticsWeight");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}
	}


	[GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[SerializableAttribute()]
	[DebuggerStepThroughAttribute()]
	[DesignerCategoryAttribute("code")]
	public partial class PoliticsWeight : object, INotifyPropertyChanged
	{

		private string politicsField;

		private float weightField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Politics
		{
			get
			{
				return this.politicsField;
			}
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}





	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PirateFaction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(LesserFaction))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BasicFaction : Faction
	{

		private XmlNamedReference affinityMappingField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference AffinityMapping
		{
			get
			{
				return this.affinityMappingField;
			}
			set
			{
				this.affinityMappingField = value;
				this.RaisePropertyChanged("AffinityMapping");
			}
		}
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MajorFaction : Faction
	{
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MinorFaction : Faction
	{

		private XmlNamedReference personalityField;

		private XmlNamedReference politicsField;

		private ColonizablePlanetType[] colonizablePlanetField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Personality
		{
			get
			{
				return this.personalityField;
			}
			set
			{
				this.personalityField = value;
				this.RaisePropertyChanged("Personality");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Politics
		{
			get
			{
				return this.politicsField;
			}
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ColonizablePlanet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ColonizablePlanetType[] ColonizablePlanet
		{
			get
			{
				return this.colonizablePlanetField;
			}
			set
			{
				this.colonizablePlanetField = value;
				this.RaisePropertyChanged("ColonizablePlanet");
			}
		}
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class LesserFaction : BasicFaction
	{
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PirateFaction : BasicFaction
	{
	}

}