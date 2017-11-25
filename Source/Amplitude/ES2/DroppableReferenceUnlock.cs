namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableReferenceUnlock : DroppableReferenceOfUnlockDatatableElement
	{

		private string simulationDescriptorReferenceField;

		private string simulationTagField;

		private bool constrainedField;

		private bool applyOnEmpireField;

		public DroppableReferenceUnlock()
		{
			this.constrainedField = true;
			this.applyOnEmpireField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SimulationDescriptorReference
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
		public string SimulationTag
		{
			get
			{
				return this.simulationTagField;
			}
			set
			{
				this.simulationTagField = value;
				this.RaisePropertyChanged("SimulationTag");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool Constrained
		{
			get
			{
				return this.constrainedField;
			}
			set
			{
				this.constrainedField = value;
				this.RaisePropertyChanged("Constrained");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ApplyOnEmpire
		{
			get
			{
				return this.applyOnEmpireField;
			}
			set
			{
				this.applyOnEmpireField = value;
				this.RaisePropertyChanged("ApplyOnEmpire");
			}
		}
	}
}
