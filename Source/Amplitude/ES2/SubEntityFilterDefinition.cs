namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SubEntityFilterDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private EncounterEntityFilterDefinition subEntityFilterField;

		private SubEntitySelectionMethodEnum subEntitySelectionMethodField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEntityFilterDefinition SubEntityFilter
		{
			get
			{
				return this.subEntityFilterField;
			}
			set
			{
				this.subEntityFilterField = value;
				this.RaisePropertyChanged("SubEntityFilter");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public SubEntitySelectionMethodEnum SubEntitySelectionMethod
		{
			get
			{
				return this.subEntitySelectionMethodField;
			}
			set
			{
				this.subEntitySelectionMethodField = value;
				this.RaisePropertyChanged("SubEntitySelectionMethod");
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
