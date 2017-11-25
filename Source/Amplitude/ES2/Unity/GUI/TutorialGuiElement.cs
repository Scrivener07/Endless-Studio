namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TutorialGuiElement : QuestGuiElement
	{

		private string popupTitleField;

		private TutorialPage[] popupPageField;

		private TutorialPopupAnchorMode anchorModeField;

		public TutorialGuiElement()
		{
			this.anchorModeField = TutorialPopupAnchorMode.BelowPinnedQuest;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PopupTitle
		{
			get
			{
				return this.popupTitleField;
			}
			set
			{
				this.popupTitleField = value;
				this.RaisePropertyChanged("PopupTitle");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PopupPage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TutorialPage[] PopupPage
		{
			get
			{
				return this.popupPageField;
			}
			set
			{
				this.popupPageField = value;
				this.RaisePropertyChanged("PopupPage");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(TutorialPopupAnchorMode.BelowPinnedQuest)]
		public TutorialPopupAnchorMode AnchorMode
		{
			get
			{
				return this.anchorModeField;
			}
			set
			{
				this.anchorModeField = value;
				this.RaisePropertyChanged("AnchorMode");
			}
		}
	}
}
