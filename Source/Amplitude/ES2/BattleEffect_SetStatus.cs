namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleEffect_SetStatus : BattleEffect
	{

		private EncounterEntityStatus statusField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public EncounterEntityStatus Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("Status");
			}
		}
	}
}
