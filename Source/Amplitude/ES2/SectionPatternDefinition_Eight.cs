namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SectionPatternDefinition_Eight : SectionPatternDefinition
	{

		private SectionDefinition[] sectionField;


		[System.Xml.Serialization.XmlElementAttribute("Section", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SectionDefinition[] Section
		{
			get
			{
				return this.sectionField;
			}
			set
			{
				this.sectionField = value;
				this.RaisePropertyChanged("Section");
			}
		}
	}
}
