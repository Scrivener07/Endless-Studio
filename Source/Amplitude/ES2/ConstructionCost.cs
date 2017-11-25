namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ConstructionCost : object, System.ComponentModel.INotifyPropertyChanged
	{

		private bool instantField;

		private bool instantOnCompletionField;

		private string resourceNameField;

		private float valueField;

		public ConstructionCost()
		{
			this.instantField = false;
			this.instantOnCompletionField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Instant
		{
			get
			{
				return this.instantField;
			}
			set
			{
				this.instantField = value;
				this.RaisePropertyChanged("Instant");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool InstantOnCompletion
		{
			get
			{
				return this.instantOnCompletionField;
			}
			set
			{
				this.instantOnCompletionField = value;
				this.RaisePropertyChanged("InstantOnCompletion");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ResourceName
		{
			get
			{
				return this.resourceNameField;
			}
			set
			{
				this.resourceNameField = value;
				this.RaisePropertyChanged("ResourceName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public float Value
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
