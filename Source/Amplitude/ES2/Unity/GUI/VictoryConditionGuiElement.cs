namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class VictoryConditionGuiElement : ExtendedGuiElement
	{

		private string progressStringField;

		private string allianceProgressStringField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ProgressString
		{
			get
			{
				return this.progressStringField;
			}
			set
			{
				this.progressStringField = value;
				this.RaisePropertyChanged("ProgressString");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AllianceProgressString
		{
			get
			{
				return this.allianceProgressStringField;
			}
			set
			{
				this.allianceProgressStringField = value;
				this.RaisePropertyChanged("AllianceProgressString");
			}
		}
	}
}
