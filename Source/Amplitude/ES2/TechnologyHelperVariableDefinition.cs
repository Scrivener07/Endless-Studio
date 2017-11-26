namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TechnologyHelperVariableDefinition : DatatableElement
	{

		private TechnologyHelperOperationItem[] itemsField;


		[System.Xml.Serialization.XmlElementAttribute("Int", typeof(TechnologyHelperOperationInt), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Operation", typeof(TechnologyHelperOperation), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("RefinedProperty", typeof(TechnologyHelperOperationRefinedProperty), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Value", typeof(TechnologyHelperOperationValue), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TechnologyHelperOperationItem[] Items
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
	}
}
