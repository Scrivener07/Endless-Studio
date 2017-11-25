namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetTransformation : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SerializableVector3 revolutionAnglesField;

		private SerializableVector3 positionAnglesField;

		private float orbitDistanceField;

		private float radiusField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 RevolutionAngles
		{
			get
			{
				return this.revolutionAnglesField;
			}
			set
			{
				this.revolutionAnglesField = value;
				this.RaisePropertyChanged("RevolutionAngles");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 PositionAngles
		{
			get
			{
				return this.positionAnglesField;
			}
			set
			{
				this.positionAnglesField = value;
				this.RaisePropertyChanged("PositionAngles");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float OrbitDistance
		{
			get
			{
				return this.orbitDistanceField;
			}
			set
			{
				this.orbitDistanceField = value;
				this.RaisePropertyChanged("OrbitDistance");
			}
		}


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
