namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(WorldSettingDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GameSettingDefinition : DatatableElement
	{

		private string editableValueField;

		private CounterIncrementer[] incrementCountField;

		private AccessibilitySetter visibleField;

		private AccessibilitySetter enableField;

		private ItemDefinition[] itemDefinitionField;

		private string typeField;

		private string defaultField;

		private string isEditableField;

		private string sessionSpecificField;

		private bool notNullOrEmptyField;

		public GameSettingDefinition()
		{
			this.notNullOrEmptyField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string EditableValue
		{
			get
			{
				return this.editableValueField;
			}
			set
			{
				this.editableValueField = value;
				this.RaisePropertyChanged("EditableValue");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("IncrementCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CounterIncrementer[] IncrementCount
		{
			get
			{
				return this.incrementCountField;
			}
			set
			{
				this.incrementCountField = value;
				this.RaisePropertyChanged("IncrementCount");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AccessibilitySetter Visible
		{
			get
			{
				return this.visibleField;
			}
			set
			{
				this.visibleField = value;
				this.RaisePropertyChanged("Visible");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AccessibilitySetter Enable
		{
			get
			{
				return this.enableField;
			}
			set
			{
				this.enableField = value;
				this.RaisePropertyChanged("Enable");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ItemDefinition", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ItemDefinition[] ItemDefinition
		{
			get
			{
				return this.itemDefinitionField;
			}
			set
			{
				this.itemDefinitionField = value;
				this.RaisePropertyChanged("ItemDefinition");
			}
		}


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
		public string Default
		{
			get
			{
				return this.defaultField;
			}
			set
			{
				this.defaultField = value;
				this.RaisePropertyChanged("Default");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IsEditable
		{
			get
			{
				return this.isEditableField;
			}
			set
			{
				this.isEditableField = value;
				this.RaisePropertyChanged("IsEditable");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SessionSpecific
		{
			get
			{
				return this.sessionSpecificField;
			}
			set
			{
				this.sessionSpecificField = value;
				this.RaisePropertyChanged("SessionSpecific");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool NotNullOrEmpty
		{
			get
			{
				return this.notNullOrEmptyField;
			}
			set
			{
				this.notNullOrEmptyField = value;
				this.RaisePropertyChanged("NotNullOrEmpty");
			}
		}
	}
}
