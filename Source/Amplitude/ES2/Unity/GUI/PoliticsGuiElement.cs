namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PoliticsGuiElement : ExtendedGuiElement
	{

		private string modelPathField;

		private string politicsAffectingEventsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ModelPath
		{
			get
			{
				return this.modelPathField;
			}
			set
			{
				this.modelPathField = value;
				this.RaisePropertyChanged("ModelPath");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PoliticsAffectingEvents
		{
			get
			{
				return this.politicsAffectingEventsField;
			}
			set
			{
				this.politicsAffectingEventsField = value;
				this.RaisePropertyChanged("PoliticsAffectingEvents");
			}
		}
	}
}
