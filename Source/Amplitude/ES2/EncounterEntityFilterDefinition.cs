namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class EncounterEntityFilterDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Prerequisite[] itemsField;

		private EncounterEntityType entityTypeField;

		private EncounterEntityTags entityTagsField;

		public EncounterEntityFilterDefinition()
		{
			this.entityTypeField = EncounterEntityType.Undefined;
			this.entityTagsField = EncounterEntityTags.None;
		}


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
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


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(EncounterEntityType.Undefined)]
		public EncounterEntityType EntityType
		{
			get
			{
				return this.entityTypeField;
			}
			set
			{
				this.entityTypeField = value;
				this.RaisePropertyChanged("EntityType");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(EncounterEntityTags.None)]
		public EncounterEntityTags EntityTags
		{
			get
			{
				return this.entityTagsField;
			}
			set
			{
				this.entityTagsField = value;
				this.RaisePropertyChanged("EntityTags");
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
}
