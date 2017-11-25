namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class StarSystemNodeDefinition : DatatableElement
	{

		private XmlNamedReference[] simulationDescriptorReferenceField;

		private PlanetDefinition[] planetDefinitionField;


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


		[System.Xml.Serialization.XmlElementAttribute("PlanetDefinition", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetDefinition[] PlanetDefinition
		{
			get
			{
				return this.planetDefinitionField;
			}
			set
			{
				this.planetDefinitionField = value;
				this.RaisePropertyChanged("PlanetDefinition");
			}
		}
	}
}
