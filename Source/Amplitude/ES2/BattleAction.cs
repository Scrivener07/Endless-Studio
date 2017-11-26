namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleAction : DatatableElement
	{

		private EncounterEventPrerequisiteDefinition eventPrerequisiteField;

		private Prerequisite[] itemsField;

		private BattleEffectApplicationContextDefinition[] battleEffectApplicationContextField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEventPrerequisiteDefinition EventPrerequisite
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


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("BattleEffectApplicationContext", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public BattleEffectApplicationContextDefinition[] BattleEffectApplicationContext
		{
			get
			{
				return this.battleEffectApplicationContextField;
			}
			set
			{
				this.battleEffectApplicationContextField = value;
				this.RaisePropertyChanged("BattleEffectApplicationContext");
			}
		}
	}
}
