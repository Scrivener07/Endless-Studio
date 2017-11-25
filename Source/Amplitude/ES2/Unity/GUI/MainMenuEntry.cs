namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class MainMenuEntry : object, System.ComponentModel.INotifyPropertyChanged
	{

		private MainMenuSubEntry[] subEntryField;

		private string nameField;

		private bool coloredField;

		private bool enabledField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubEntry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MainMenuSubEntry[] SubEntry
		{
			get
			{
				return this.subEntryField;
			}
			set
			{
				this.subEntryField = value;
				this.RaisePropertyChanged("SubEntry");
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
		public bool Colored
		{
			get
			{
				return this.coloredField;
			}
			set
			{
				this.coloredField = value;
				this.RaisePropertyChanged("Colored");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool Enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				this.enabledField = value;
				this.RaisePropertyChanged("Enabled");
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
