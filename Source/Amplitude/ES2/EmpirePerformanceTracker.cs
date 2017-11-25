namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class EmpirePerformanceTracker : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] variableField;

		private string nameField;

		private PerformanceType typeField;

		private bool hiddenField;

		public EmpirePerformanceTracker()
		{
			this.hiddenField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute("Variable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] Variable
		{
			get
			{
				return this.variableField;
			}
			set
			{
				this.variableField = value;
				this.RaisePropertyChanged("Variable");
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


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public PerformanceType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
				this.RaisePropertyChanged("Hidden");
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
