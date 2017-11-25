namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ResourceDepositDefinitionWithSize : ValueType
	{

		private XmlNamedReference definitionReferenceField;

		private XmlNamedReference sizeDescriptorReferenceField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference DefinitionReference
		{
			get
			{
				return this.definitionReferenceField;
			}
			set
			{
				this.definitionReferenceField = value;
				this.RaisePropertyChanged("DefinitionReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference SizeDescriptorReference
		{
			get
			{
				return this.sizeDescriptorReferenceField;
			}
			set
			{
				this.sizeDescriptorReferenceField = value;
				this.RaisePropertyChanged("SizeDescriptorReference");
			}
		}
	}
}
