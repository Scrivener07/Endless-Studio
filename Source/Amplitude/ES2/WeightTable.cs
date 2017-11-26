namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(GalaxyGeneratorWeightTable))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class WeightTable : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Entry[] entryField;

		private string nameField;


		[System.Xml.Serialization.XmlElementAttribute("Entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Entry[] Entry
		{
			get
			{
				return this.entryField;
			}
			set
			{
				this.entryField = value;
				this.RaisePropertyChanged("Entry");
			}
		}


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
