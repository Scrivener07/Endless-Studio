namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PlanetDefinition : ValueType
	{

		private XmlNamedReference[] simulationDescriptorReferenceField;

		private XmlNamedReference[] anomalyReferenceField;

		private XmlNamedReference[] curiosityReferenceField;

		private ResourceDepositDefinitionWithSize[] resourceDepositField;


		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] SimulationDescriptorReference
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


		[System.Xml.Serialization.XmlElementAttribute("AnomalyReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] AnomalyReference
		{
			get
			{
				return this.anomalyReferenceField;
			}
			set
			{
				this.anomalyReferenceField = value;
				this.RaisePropertyChanged("AnomalyReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("CuriosityReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] CuriosityReference
		{
			get
			{
				return this.curiosityReferenceField;
			}
			set
			{
				this.curiosityReferenceField = value;
				this.RaisePropertyChanged("CuriosityReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ResourceDeposit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResourceDepositDefinitionWithSize[] ResourceDeposit
		{
			get
			{
				return this.resourceDepositField;
			}
			set
			{
				this.resourceDepositField = value;
				this.RaisePropertyChanged("ResourceDeposit");
			}
		}
	}
}
