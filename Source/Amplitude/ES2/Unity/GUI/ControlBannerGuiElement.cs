namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ControlBannerGuiElement : GuiElement
	{

		private ControlBannerElement[] controlBannerElementField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ControlBannerElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ControlBannerElement[] ControlBannerElement
		{
			get
			{
				return this.controlBannerElementField;
			}
			set
			{
				this.controlBannerElementField = value;
				this.RaisePropertyChanged("ControlBannerElement");
			}
		}
	}
}
