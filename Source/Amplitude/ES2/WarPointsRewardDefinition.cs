namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class WarPointsRewardDefinition : DatatableElement
	{

		private string formulaField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Formula
		{
			get
			{
				return this.formulaField;
			}
			set
			{
				this.formulaField = value;
				this.RaisePropertyChanged("Formula");
			}
		}
	}
}
