namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlanetTierDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] planetTypeField;

		private string modelField;

		private int rankField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetType
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
		public string Model
		{
			get
			{
				return this.modelField;
			}
			set
			{
				this.modelField = value;
				this.RaisePropertyChanged("Model");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
				this.RaisePropertyChanged("Rank");
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
