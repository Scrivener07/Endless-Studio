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
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(MajorFaction))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot("Faction", Namespace = "", IsNullable = true)]
	public class Faction : DatatableElement
	{
		private XmlNamedReference affinityField;

		private ObservableListSource<XmlNamedReference> traitField;

		private FactionTraitStartingSenate traitStartingSenateField;

		private ObservableListSource<XmlNamedReference> bailiffField;

		private StartingPopulation majorPopulationField;

		private ObservableListSource<StartingPopulation> minorPopulationField;

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
			this.affinityField = new XmlNamedReference();
			this.traitField = new ObservableListSource<XmlNamedReference>();
			this.traitStartingSenateField = new FactionTraitStartingSenate();
			this.bailiffField = new ObservableListSource<XmlNamedReference>();
			this.majorPopulationField = new StartingPopulation();
			this.minorPopulationField = new ObservableListSource<StartingPopulation>();
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference Affinity
		{
			get { return this.affinityField; }
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}

		/// <remarks/>
		[XmlElement("Trait", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<XmlNamedReference> Trait
		{
			get { return this.traitField; }
			set
			{
				this.traitField = value;
				this.RaisePropertyChanged("Trait");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public FactionTraitStartingSenate TraitStartingSenate
		{
			get { return this.traitStartingSenateField; }
			set
			{
				this.traitStartingSenateField = value;
				this.RaisePropertyChanged("TraitStartingSenate");
			}
		}

		/// <remarks/>
		[XmlElement("Bailiff", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<XmlNamedReference> Bailiff
		{
			get { return this.bailiffField; }
			set
			{
				this.bailiffField = value;
				this.RaisePropertyChanged("Bailiff");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public StartingPopulation MajorPopulation
		{
			get { return this.majorPopulationField; }
			set
			{
				this.majorPopulationField = value;
				this.RaisePropertyChanged("MajorPopulation");
			}
		}

		/// <remarks/>
		[XmlElement("MinorPopulation", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<StartingPopulation> MinorPopulation
		{
			get { return this.minorPopulationField; }
			set
			{
				this.minorPopulationField = value;
				this.RaisePropertyChanged("MinorPopulation");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string LocalizedDescription
		{
			get { return this.localizedDescriptionField; }
			set
			{
				this.localizedDescriptionField = value;
				this.RaisePropertyChanged("LocalizedDescription");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string LocalizedName
		{
			get { return this.localizedNameField; }
			set
			{
				this.localizedNameField = value;
				this.RaisePropertyChanged("LocalizedName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string Author
		{
			get { return this.authorField; }
			set
			{
				this.authorField = value;
				this.RaisePropertyChanged("Author");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
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
		public bool Standard
		{
			get { return this.standardField; }
			set
			{
				this.standardField = value;
				this.RaisePropertyChanged("Standard");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public short Priority
		{
			get { return this.priorityField; }
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}


	}
}
