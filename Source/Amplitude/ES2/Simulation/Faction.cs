using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(MajorFaction))]
	[XmlRoot(Namespace = "", IsNullable = true)]
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


		[XmlElement("Trait", Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] Trait
		{
			get { return this.traitField; }
			set
			{
				this.traitField = value;
				this.RaisePropertyChanged("Trait");
			}
		}


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


		[XmlElement("Bailiff", Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] Bailiff
		{
			get { return this.bailiffField; }
			set
			{
				this.bailiffField = value;
				this.RaisePropertyChanged("Bailiff");
			}
		}


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


		[XmlElement("MinorPopulation", Form = XmlSchemaForm.Unqualified)]
		public StartingPopulation[] MinorPopulation
		{
			get { return this.minorPopulationField; }
			set
			{
				this.minorPopulationField = value;
				this.RaisePropertyChanged("MinorPopulation");
			}
		}


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