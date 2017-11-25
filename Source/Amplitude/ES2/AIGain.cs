namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class AIGain : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] tagField;

		private string ressourceNameField;

		private bool invertedField;

		public AIGain()
		{
			this.invertedField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Tag", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] Tag
		{
			get
			{
				return this.tagField;
			}
			set
			{
				this.tagField = value;
				this.RaisePropertyChanged("Tag");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string RessourceName
		{
			get
			{
				return this.ressourceNameField;
			}
			set
			{
				this.ressourceNameField = value;
				this.RaisePropertyChanged("RessourceName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Inverted
		{
			get
			{
				return this.invertedField;
			}
			set
			{
				this.invertedField = value;
				this.RaisePropertyChanged("Inverted");
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
