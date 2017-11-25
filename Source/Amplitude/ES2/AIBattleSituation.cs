namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class AIBattleSituation : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string situationField;

		private SituationMode modeField;

		private float valueField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Situation
		{
			get
			{
				return this.situationField;
			}
			set
			{
				this.situationField = value;
				this.RaisePropertyChanged("Situation");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public SituationMode Mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				this.modeField = value;
				this.RaisePropertyChanged("Mode");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Value
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
