namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class EncounterEntityFilterDefinition_BattleActionRole : EncounterEntityFilterDefinition
	{

		private BattleActionEntityRole entityRoleField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public BattleActionEntityRole EntityRole
		{
			get
			{
				return this.entityRoleField;
			}
			set
			{
				this.entityRoleField = value;
				this.RaisePropertyChanged("EntityRole");
			}
		}
	}
}
