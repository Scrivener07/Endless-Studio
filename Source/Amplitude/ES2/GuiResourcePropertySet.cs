namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiResourcePropertySet : DatatableElement
	{

		private GuiResourcePropertySetItem[] propertyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GuiResourcePropertySetItem[] Property
		{
			get
			{
				return this.propertyField;
			}
			set
			{
				this.propertyField = value;
				this.RaisePropertyChanged("Property");
			}
		}
	}
}
