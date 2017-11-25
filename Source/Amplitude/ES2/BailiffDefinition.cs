namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BailiffDefinition : DatatableElement
	{

		private BailiffPass[] passField;

		private string resourceField;


		[System.Xml.Serialization.XmlElementAttribute("Pass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public BailiffPass[] Pass
		{
			get
			{
				return this.passField;
			}
			set
			{
				this.passField = value;
				this.RaisePropertyChanged("Pass");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Resource
		{
			get
			{
				return this.resourceField;
			}
			set
			{
				this.resourceField = value;
				this.RaisePropertyChanged("Resource");
			}
		}
	}
}
