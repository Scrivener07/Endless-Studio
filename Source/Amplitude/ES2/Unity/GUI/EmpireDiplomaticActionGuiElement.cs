namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class EmpireDiplomaticActionGuiElement : EmpireActionGuiElement
	{

		private bool closeWindowOnActionStartField;

		public EmpireDiplomaticActionGuiElement()
		{
			this.closeWindowOnActionStartField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool CloseWindowOnActionStart
		{
			get
			{
				return this.closeWindowOnActionStartField;
			}
			set
			{
				this.closeWindowOnActionStartField = value;
				this.RaisePropertyChanged("CloseWindowOnActionStart");
			}
		}
	}
}
