namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SlaveModuleDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string nameField;

		private string categoryForSimulationDescriptorsField;


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
		public string CategoryForSimulationDescriptors
		{
			get
			{
				return this.categoryForSimulationDescriptorsField;
			}
			set
			{
				this.categoryForSimulationDescriptorsField = value;
				this.RaisePropertyChanged("CategoryForSimulationDescriptors");
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
