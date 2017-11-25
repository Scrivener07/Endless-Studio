namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class LineOfSight : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SerializableDirection directionField;

		private float angleField;

		private string[] visualSlotNameField;

		public LineOfSight()
		{
			this.angleField = ((float)(90F));
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableDirection Direction
		{
			get
			{
				return this.directionField;
			}
			set
			{
				this.directionField = value;
				this.RaisePropertyChanged("Direction");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "90")]
		public float Angle
		{
			get
			{
				return this.angleField;
			}
			set
			{
				this.angleField = value;
				this.RaisePropertyChanged("Angle");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("VisualSlotName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] VisualSlotName
		{
			get
			{
				return this.visualSlotNameField;
			}
			set
			{
				this.visualSlotNameField = value;
				this.RaisePropertyChanged("VisualSlotName");
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
