namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetoidRadiusFromPlanetSize : object, System.ComponentModel.INotifyPropertyChanged
	{

		private float radiusField;

		private string planetSizeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Radius
		{
			get
			{
				return this.radiusField;
			}
			set
			{
				this.radiusField = value;
				this.RaisePropertyChanged("Radius");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PlanetSize
		{
			get
			{
				return this.planetSizeField;
			}
			set
			{
				this.planetSizeField = value;
				this.RaisePropertyChanged("PlanetSize");
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
