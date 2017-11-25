namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SlotLinkDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] slotNameField;

		private SlotLinkEffectDefinition[] effectField;


		[System.Xml.Serialization.XmlElementAttribute("SlotName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] SlotName
		{
			get
			{
				return this.slotNameField;
			}
			set
			{
				this.slotNameField = value;
				this.RaisePropertyChanged("SlotName");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Effect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotLinkEffectDefinition[] Effect
		{
			get
			{
				return this.effectField;
			}
			set
			{
				this.effectField = value;
				this.RaisePropertyChanged("Effect");
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
