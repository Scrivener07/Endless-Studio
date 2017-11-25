namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraTargetSelectionMethodDefinition_EncounterEntity : CameraTargetSelectionMethodDefinition
	{

		private EncounterEventEntityRole eventEntityRoleField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public EncounterEventEntityRole EventEntityRole
		{
			get
			{
				return this.eventEntityRoleField;
			}
			set
			{
				this.eventEntityRoleField = value;
				this.RaisePropertyChanged("EventEntityRole");
			}
		}
	}
}
