namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition_Audio : CameraAlterationDefinition
	{

		private string startEventNameField;

		private string endEventNameField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StartEventName
		{
			get
			{
				return this.startEventNameField;
			}
			set
			{
				this.startEventNameField = value;
				this.RaisePropertyChanged("StartEventName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EndEventName
		{
			get
			{
				return this.endEventNameField;
			}
			set
			{
				this.endEventNameField = value;
				this.RaisePropertyChanged("EndEventName");
			}
		}
	}
}
