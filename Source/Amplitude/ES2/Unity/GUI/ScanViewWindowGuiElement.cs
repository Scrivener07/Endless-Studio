namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PlanetScanViewWindowGuiElement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(StarSystemOverviewScanViewGuiElement))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ScanViewWindowGuiElement : GuiElement
	{

		private ScanViewCaptionGroupGuiElement[] scanViewCaptionGroupGuiElementField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ScanViewCaptionGroupGuiElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ScanViewCaptionGroupGuiElement[] ScanViewCaptionGroupGuiElement
		{
			get
			{
				return this.scanViewCaptionGroupGuiElementField;
			}
			set
			{
				this.scanViewCaptionGroupGuiElementField = value;
				this.RaisePropertyChanged("ScanViewCaptionGroupGuiElement");
			}
		}
	}
}
