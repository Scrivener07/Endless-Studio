namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ContextualDiplomaticTermGuiElement : ExtendedGuiElement
	{

		private string termTitleField;

		private string termDescriptionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TermTitle
		{
			get
			{
				return this.termTitleField;
			}
			set
			{
				this.termTitleField = value;
				this.RaisePropertyChanged("TermTitle");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TermDescription
		{
			get
			{
				return this.termDescriptionField;
			}
			set
			{
				this.termDescriptionField = value;
				this.RaisePropertyChanged("TermDescription");
			}
		}
	}
}
