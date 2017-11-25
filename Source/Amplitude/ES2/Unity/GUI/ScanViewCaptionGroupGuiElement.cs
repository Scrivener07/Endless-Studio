namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ScanViewCaptionGroupGuiElement : GuiElement
	{

		private ScanViewCaptionItemGuiElement[] scanViewCaptionItemGuiElementField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ScanViewCaptionItemGuiElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ScanViewCaptionItemGuiElement[] ScanViewCaptionItemGuiElement
		{
			get
			{
				return this.scanViewCaptionItemGuiElementField;
			}
			set
			{
				this.scanViewCaptionItemGuiElementField = value;
				this.RaisePropertyChanged("ScanViewCaptionItemGuiElement");
			}
		}
	}
}
