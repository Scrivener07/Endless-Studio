namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PopulationCollectionBonusTrait))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PopulationModifiersTrait))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PopulationPoliticalTraitDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PopulationTrait : DatatableElement
	{

		private string tagsField;

		private XmlNamedReference[] subtraitField;

		private Command[] commandField;

		private string categoryField;

		private string subCategoryField;

		private int costField;

		private bool showInCustomField;

		public PopulationTrait()
		{
			this.costField = 0;
			this.showInCustomField = true;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Tags
		{
			get
			{
				return this.tagsField;
			}
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Subtrait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] Subtrait
		{
			get
			{
				return this.subtraitField;
			}
			set
			{
				this.subtraitField = value;
				this.RaisePropertyChanged("Subtrait");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool ShowInCustom
		{
			get
			{
				return this.showInCustomField;
			}
			set
			{
				this.showInCustomField = value;
				this.RaisePropertyChanged("ShowInCustom");
			}
		}
	}
}
