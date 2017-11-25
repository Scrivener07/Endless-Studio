namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlanetTemperatureDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string planetTypeField;

		private int temperatureField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PlanetType
		{
			get
			{
				return this.planetTypeField;
			}
			set
			{
				this.planetTypeField = value;
				this.RaisePropertyChanged("PlanetType");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Temperature
		{
			get
			{
				return this.temperatureField;
			}
			set
			{
				this.temperatureField = value;
				this.RaisePropertyChanged("Temperature");
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
