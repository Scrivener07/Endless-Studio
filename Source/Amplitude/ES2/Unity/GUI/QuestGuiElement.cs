namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TutorialGuiElement))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class QuestGuiElement : GuiElement
	{

		private StepGuiElement[] stepsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Step", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public StepGuiElement[] Steps
		{
			get
			{
				return this.stepsField;
			}
			set
			{
				this.stepsField = value;
				this.RaisePropertyChanged("Steps");
			}
		}
	}
}
