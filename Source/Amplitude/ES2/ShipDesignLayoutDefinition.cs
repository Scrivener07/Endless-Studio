namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ShipDesignLayoutDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Prerequisite[] itemsField;

		private XmlNamedReference shipRoleReferenceField;

		private SectionPatternDefinition[] items1Field;

		private SlotLinkDefinition[] linkField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
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


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference ShipRoleReference
		{
			get
			{
				return this.shipRoleReferenceField;
			}
			set
			{
				this.shipRoleReferenceField = value;
				this.RaisePropertyChanged("ShipRoleReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("SectionPattern", typeof(SectionPatternDefinition), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SectionPattern_Eight", typeof(SectionPatternDefinition_Eight), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SectionPattern_Four", typeof(SectionPatternDefinition_Four), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SectionPatternDefinition[] Items1
		{
			get
			{
				return this.items1Field;
			}
			set
			{
				this.items1Field = value;
				this.RaisePropertyChanged("Items1");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotLinkDefinition[] Link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
				this.RaisePropertyChanged("Link");
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
