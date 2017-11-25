namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class XmlColorReference : XmlNamedReference
	{

		private XmlColor colorField;

		private Tags tagsField;

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
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get
			{
				return this.tagsField;
			}
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}
	}
}
