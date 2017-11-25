namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetStat : object, System.ComponentModel.INotifyPropertyChanged
	{

		private PlanetStatDetail[] statDetailField;

		private string nameField;

		private float minField;

		private float maxField;

		private string valueField;

		public PlanetStat()
		{
			this.minField = ((float)(-3.402823E+38F));
			this.maxField = ((float)(3.402823E+38F));
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StatDetail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatDetail[] StatDetail
		{
			get
			{
				return this.statDetailField;
			}
			set
			{
				this.statDetailField = value;
				this.RaisePropertyChanged("StatDetail");
			}
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

		/// <remarks/>
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
