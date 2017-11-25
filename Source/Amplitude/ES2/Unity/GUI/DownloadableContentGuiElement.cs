namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class DownloadableContentGuiElement : GuiElement
	{

		private string loreDescriptionField;

		private string contentDescriptionField;

		private bool notifyField;

		public DownloadableContentGuiElement()
		{
			this.notifyField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string LoreDescription
		{
			get
			{
				return this.loreDescriptionField;
			}
			set
			{
				this.loreDescriptionField = value;
				this.RaisePropertyChanged("LoreDescription");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ContentDescription
		{
			get
			{
				return this.contentDescriptionField;
			}
			set
			{
				this.contentDescriptionField = value;
				this.RaisePropertyChanged("ContentDescription");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Notify
		{
			get
			{
				return this.notifyField;
			}
			set
			{
				this.notifyField = value;
				this.RaisePropertyChanged("Notify");
			}
		}
	}
}
