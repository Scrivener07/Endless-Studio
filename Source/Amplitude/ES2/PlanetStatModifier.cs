namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetStatModifier : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string nameField;

		private float multiplyField;

		private float addField;

		private string overrideField;

		public PlanetStatModifier()
		{
			this.multiplyField = ((float)(1F));
			this.addField = ((float)(0F));
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
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float Multiply
		{
			get
			{
				return this.multiplyField;
			}
			set
			{
				this.multiplyField = value;
				this.RaisePropertyChanged("Multiply");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float Add
		{
			get
			{
				return this.addField;
			}
			set
			{
				this.addField = value;
				this.RaisePropertyChanged("Add");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Override
		{
			get
			{
				return this.overrideField;
			}
			set
			{
				this.overrideField = value;
				this.RaisePropertyChanged("Override");
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
