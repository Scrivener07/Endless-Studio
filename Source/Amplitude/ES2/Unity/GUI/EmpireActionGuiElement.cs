namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmpireDiplomaticActionGuiElement))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class EmpireActionGuiElement : EntityActionGuiElement
	{

		private string confirmationMessageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ConfirmationMessage
		{
			get
			{
				return this.confirmationMessageField;
			}
			set
			{
				this.confirmationMessageField = value;
				this.RaisePropertyChanged("ConfirmationMessage");
			}
		}
	}
}
