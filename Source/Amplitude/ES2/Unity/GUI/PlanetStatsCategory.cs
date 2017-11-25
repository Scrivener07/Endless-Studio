namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetStatsCategory : object, System.ComponentModel.INotifyPropertyChanged
	{

		private PlanetStatsEntry[] entryField;

		private string nameField;

		private CategorySide sideField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatsEntry[] Entry
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
		public CategorySide Side
		{
			get
			{
				return this.sideField;
			}
			set
			{
				this.sideField = value;
				this.RaisePropertyChanged("Side");
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
