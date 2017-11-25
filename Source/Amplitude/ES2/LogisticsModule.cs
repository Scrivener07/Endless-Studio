namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class LogisticsModule : SupportModule
	{

		private string[] resourceField;


		[System.Xml.Serialization.XmlElementAttribute("Resource", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] Resource
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
