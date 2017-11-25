namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiHighlightDefinition : DatatableElement
	{

		private XmlColor colorField;

		private bool persistentField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlColor Color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
				this.RaisePropertyChanged("Color");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool Persistent
		{
			get
			{
				return this.persistentField;
			}
			set
			{
				this.persistentField = value;
				this.RaisePropertyChanged("Persistent");
			}
		}
	}
}
