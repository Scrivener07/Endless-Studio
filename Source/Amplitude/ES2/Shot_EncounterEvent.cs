namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class Shot_EncounterEvent : Shot
	{

		private EncounterRealizationEventPrerequisiteDefinition eventPrerequisiteField;

		private float eventStartTimeRatioField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterRealizationEventPrerequisiteDefinition EventPrerequisite
		{
			get
			{
				return this.eventPrerequisiteField;
			}
			set
			{
				this.eventPrerequisiteField = value;
				this.RaisePropertyChanged("EventPrerequisite");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float EventStartTimeRatio
		{
			get
			{
				return this.eventStartTimeRatioField;
			}
			set
			{
				this.eventStartTimeRatioField = value;
				this.RaisePropertyChanged("EventStartTimeRatio");
			}
		}
	}
}
