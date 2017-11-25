namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PopulationPoliticalTraitDefinition : PopulationTrait
	{

		private SimulationDescriptorReference simulationDescriptorReferenceField;

		private XmlNamedReference[] subFactionTraitField;

		private TraitType typeField;

		private string politicalTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference SimulationDescriptorReference
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
		[System.Xml.Serialization.XmlElementAttribute("SubFactionTrait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] SubFactionTrait
		{
			get
			{
				return this.subFactionTraitField;
			}
			set
			{
				this.subFactionTraitField = value;
				this.RaisePropertyChanged("SubFactionTrait");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public TraitType Type
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PoliticalType
		{
			get
			{
				return this.politicalTypeField;
			}
			set
			{
				this.politicalTypeField = value;
				this.RaisePropertyChanged("PoliticalType");
			}
		}
	}
}
