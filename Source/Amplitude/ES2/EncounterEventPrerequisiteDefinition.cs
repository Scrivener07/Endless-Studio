namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class EncounterEventPrerequisiteDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private EncounterEntityFilterDefinition eventInitiatorFilterField;

		private EncounterEntityFilterDefinition eventTargetFilterField;

		private EncounterEventType eventTypeField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEntityFilterDefinition EventInitiatorFilter
		{
			get
			{
				return this.eventInitiatorFilterField;
			}
			set
			{
				this.eventInitiatorFilterField = value;
				this.RaisePropertyChanged("EventInitiatorFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEntityFilterDefinition EventTargetFilter
		{
			get
			{
				return this.eventTargetFilterField;
			}
			set
			{
				this.eventTargetFilterField = value;
				this.RaisePropertyChanged("EventTargetFilter");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public EncounterEventType EventType
		{
			get
			{
				return this.eventTypeField;
			}
			set
			{
				this.eventTypeField = value;
				this.RaisePropertyChanged("EventType");
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
