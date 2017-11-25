namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SectionDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] visualSectionNameField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private SlotDefinition[] itemsField;

		private string nameField;


		[System.Xml.Serialization.XmlElementAttribute("VisualSectionName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] VisualSectionName
		{
			get
			{
				return this.visualSectionNameField;
			}
			set
			{
				this.visualSectionNameField = value;
				this.RaisePropertyChanged("VisualSectionName");
			}
		}


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


		[System.Xml.Serialization.XmlElementAttribute("Slot", typeof(SlotDefinition), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("WeaponSlot", typeof(WeaponSlotDefinition), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotDefinition[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
