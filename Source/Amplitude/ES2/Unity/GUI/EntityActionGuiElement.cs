namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmpireActionGuiElement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmpireDiplomaticActionGuiElement))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class EntityActionGuiElement : ExtendedGuiElement
	{

		private string associatedPoliticsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AssociatedPolitics
		{
			get
			{
				return this.associatedPoliticsField;
			}
			set
			{
				this.associatedPoliticsField = value;
				this.RaisePropertyChanged("AssociatedPolitics");
			}
		}
	}
}
