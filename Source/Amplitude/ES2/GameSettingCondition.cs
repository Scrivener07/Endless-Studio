namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GameSettingCondition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string gameSettingField;

		private string valueField;

		private string countField;

		private string lowerEqualField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string GameSetting
		{
			get
			{
				return this.gameSettingField;
			}
			set
			{
				this.gameSettingField = value;
				this.RaisePropertyChanged("GameSetting");
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
		public string Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string LowerEqual
		{
			get
			{
				return this.lowerEqualField;
			}
			set
			{
				this.lowerEqualField = value;
				this.RaisePropertyChanged("LowerEqual");
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
