namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class Droplist : DatatableElement
	{

		private Droppable[] itemsField;

		private int picksField;

		private DroplistSelector selectorField;

		private bool retryOnFailureField;

		private string categoryField;

		private string fallbackField;

		public Droplist()
		{
			this.picksField = 1;
			this.selectorField = DroplistSelector.Weighted;
			this.retryOnFailureField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Blueprint", typeof(DroppableBlueprint), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Faction", typeof(DroppableFaction), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Fleet", typeof(DroppableFleet), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Hero", typeof(DroppableReferenceHero), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Integer", typeof(DroppableInteger), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Law", typeof(DroppableReferenceLaw), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("List", typeof(DroppableReferenceList), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Module", typeof(DroppableModule), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Play", typeof(DroppableReferencePlay), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Resource", typeof(DroppableResource), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("String", typeof(DroppableString), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Technology", typeof(DroppableReferenceTechnology), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Unlock", typeof(DroppableReferenceUnlock), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Droppable[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int Picks
		{
			get
			{
				return this.picksField;
			}
			set
			{
				this.picksField = value;
				this.RaisePropertyChanged("Picks");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(DroplistSelector.Weighted)]
		public DroplistSelector Selector
		{
			get
			{
				return this.selectorField;
			}
			set
			{
				this.selectorField = value;
				this.RaisePropertyChanged("Selector");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool RetryOnFailure
		{
			get
			{
				return this.retryOnFailureField;
			}
			set
			{
				this.retryOnFailureField = value;
				this.RaisePropertyChanged("RetryOnFailure");
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
		public string Fallback
		{
			get
			{
				return this.fallbackField;
			}
			set
			{
				this.fallbackField = value;
				this.RaisePropertyChanged("Fallback");
			}
		}
	}
}
