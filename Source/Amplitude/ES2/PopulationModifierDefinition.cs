namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PopulationModifierDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private string classField;

		private bool displayWhenBoostedOnlyField;

		public PopulationModifierDefinition()
		{
			this.displayWhenBoostedOnlyField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SimulationDescriptorReference
		{
			get
			{
				return this.simulationDescriptorReferenceField;
			}
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Class
		{
			get
			{
				return this.classField;
			}
			set
			{
				this.classField = value;
				this.RaisePropertyChanged("Class");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DisplayWhenBoostedOnly
		{
			get
			{
				return this.displayWhenBoostedOnlyField;
			}
			set
			{
				this.displayWhenBoostedOnlyField = value;
				this.RaisePropertyChanged("DisplayWhenBoostedOnly");
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
