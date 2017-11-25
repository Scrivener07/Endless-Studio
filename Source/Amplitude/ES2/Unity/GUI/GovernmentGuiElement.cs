namespace Amplitude.ES2.Unity.GUI
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GovernmentGuiElement : GuiElement
	{

		private string leaderFormatField;

		private string electionProcessDescriptionField;

		private string lawManagementDescriptionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string LeaderFormat
		{
			get
			{
				return this.leaderFormatField;
			}
			set
			{
				this.leaderFormatField = value;
				this.RaisePropertyChanged("LeaderFormat");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ElectionProcessDescription
		{
			get
			{
				return this.electionProcessDescriptionField;
			}
			set
			{
				this.electionProcessDescriptionField = value;
				this.RaisePropertyChanged("ElectionProcessDescription");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string LawManagementDescription
		{
			get
			{
				return this.lawManagementDescriptionField;
			}
			set
			{
				this.lawManagementDescriptionField = value;
				this.RaisePropertyChanged("LawManagementDescription");
			}
		}
	}
}
