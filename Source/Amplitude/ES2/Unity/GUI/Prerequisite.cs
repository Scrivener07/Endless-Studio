namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(InterpreterPrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PathPrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PathValidityPrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyPrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuestStatePrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(GameSettingPrerequisite))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TutorialLevelPrerequisite))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Prerequisite : object, System.ComponentModel.INotifyPropertyChanged
	{

		private bool invertedField;

		private string flagsField;

		private string valueField;

		public Prerequisite()
		{
			this.invertedField = false;
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Flags
		{
			get
			{
				return this.flagsField;
			}
			set
			{
				this.flagsField = value;
				this.RaisePropertyChanged("Flags");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
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
