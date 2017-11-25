namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MinorFactionDiplomacyModalWindowGuiElement : WindowGuiElement
	{

		private MinorActionItem[] minorActionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MinorAction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MinorActionItem[] MinorAction
		{
			get
			{
				return this.minorActionField;
			}
			set
			{
				this.minorActionField = value;
				this.RaisePropertyChanged("MinorAction");
			}
		}
	}
}
