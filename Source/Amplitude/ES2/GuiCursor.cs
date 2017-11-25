namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiCursor : DatatableElement
	{

		private GuiCursorHotSpot hotSpotField;

		private GuiCursorImage imageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GuiCursorHotSpot HotSpot
		{
			get
			{
				return this.hotSpotField;
			}
			set
			{
				this.hotSpotField = value;
				this.RaisePropertyChanged("HotSpot");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GuiCursorImage Image
		{
			get
			{
				return this.imageField;
			}
			set
			{
				this.imageField = value;
				this.RaisePropertyChanged("Image");
			}
		}
	}
}
