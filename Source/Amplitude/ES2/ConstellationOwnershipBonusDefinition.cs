namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ConstellationOwnershipBonusDefinition : DatatableElement
	{

		private SimulationDescriptorReference[] colonizedStarSystemDescriptorsField;


		[System.Xml.Serialization.XmlElementAttribute("ColonizedStarSystemDescriptors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] ColonizedStarSystemDescriptors
		{
			get
			{
				return this.colonizedStarSystemDescriptorsField;
			}
			set
			{
				this.colonizedStarSystemDescriptorsField = value;
				this.RaisePropertyChanged("ColonizedStarSystemDescriptors");
			}
		}
	}
}
