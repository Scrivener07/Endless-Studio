namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetStatDetail : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string nameField;

		private float minField;

		private float maxField;

		public PlanetStatDetail()
		{
			this.minField = ((float)(-3.402823E+38F));
			this.maxField = ((float)(3.402823E+38F));
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "-3.402823E+38")]
		public float Min
		{
			get
			{
				return this.minField;
			}
			set
			{
				this.minField = value;
				this.RaisePropertyChanged("Min");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "3.402823E+38")]
		public float Max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
				this.RaisePropertyChanged("Max");
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
