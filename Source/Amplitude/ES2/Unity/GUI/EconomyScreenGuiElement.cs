namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class EconomyScreenGuiElement : WindowGuiElement
	{

		private Section[] sectionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Section", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Section[] Section
		{
			get
			{
				return this.sectionField;
			}
			set
			{
				this.sectionField = value;
				this.RaisePropertyChanged("Section");
			}
		}
	}
}
