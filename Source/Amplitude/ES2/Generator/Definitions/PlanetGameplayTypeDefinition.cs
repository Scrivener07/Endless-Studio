namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlanetGameplayTypeDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] gameplayTypeField;

		private string planetTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GameplayType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] GameplayType
		{
			get
			{
				return this.gameplayTypeField;
			}
			set
			{
				this.gameplayTypeField = value;
				this.RaisePropertyChanged("GameplayType");
			}
		}

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
