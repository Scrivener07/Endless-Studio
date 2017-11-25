namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class CuriosityTypeGuiElement : ExtendedGuiElement
	{

		private string rewardsDescriptionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string RewardsDescription
		{
			get
			{
				return this.rewardsDescriptionField;
			}
			set
			{
				this.rewardsDescriptionField = value;
				this.RaisePropertyChanged("RewardsDescription");
			}
		}
	}
}
