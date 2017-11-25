namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MothershipModule : SupportModule
	{

		private SimulationDescriptorReference[] systemDescriptorField;


		[System.Xml.Serialization.XmlElementAttribute("SystemDescriptor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SystemDescriptor
		{
			get
			{
				return this.systemDescriptorField;
			}
			set
			{
				this.systemDescriptorField = value;
				this.RaisePropertyChanged("SystemDescriptor");
			}
		}
	}
}
