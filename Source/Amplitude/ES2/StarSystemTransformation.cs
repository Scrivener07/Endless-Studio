namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class StarSystemTransformation : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SerializableVector3 positionField;

		private SerializableVector3 rotationField;

		private float scaleField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 Position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
				this.RaisePropertyChanged("Position");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 Rotation
		{
			get
			{
				return this.rotationField;
			}
			set
			{
				this.rotationField = value;
				this.RaisePropertyChanged("Rotation");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Scale
		{
			get
			{
				return this.scaleField;
			}
			set
			{
				this.scaleField = value;
				this.RaisePropertyChanged("Scale");
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
