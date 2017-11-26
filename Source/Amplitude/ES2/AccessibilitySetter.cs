namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class AccessibilitySetter : object, System.ComponentModel.INotifyPropertyChanged
	{

		private GameSettingCondition[] ifField;

		private string valueField;

		private string operatorField;


		[System.Xml.Serialization.XmlElementAttribute("If", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GameSettingCondition[] If
		{
			get
			{
				return this.ifField;
			}
			set
			{
				this.ifField = value;
				this.RaisePropertyChanged("If");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
				this.RaisePropertyChanged("Operator");
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
