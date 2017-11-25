namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition_Event : CameraAlterationDefinition
	{

		private int startEventIndexField;

		private int endEventIndexField;

		public CameraAlterationDefinition_Event()
		{
			this.startEventIndexField = 0;
			this.endEventIndexField = 0;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int StartEventIndex
		{
			get
			{
				return this.startEventIndexField;
			}
			set
			{
				this.startEventIndexField = value;
				this.RaisePropertyChanged("StartEventIndex");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int EndEventIndex
		{
			get
			{
				return this.endEventIndexField;
			}
			set
			{
				this.endEventIndexField = value;
				this.RaisePropertyChanged("EndEventIndex");
			}
		}
	}
}
