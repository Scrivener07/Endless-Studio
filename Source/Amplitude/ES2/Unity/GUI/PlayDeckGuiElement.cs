namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlayDeckGuiElement : ExtendedGuiElement
	{

		private XmlNamedReference[] unlockedPlayField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("UnlockedPlay", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] UnlockedPlay
		{
			get
			{
				return this.unlockedPlayField;
			}
			set
			{
				this.unlockedPlayField = value;
				this.RaisePropertyChanged("UnlockedPlay");
			}
		}
	}
}
