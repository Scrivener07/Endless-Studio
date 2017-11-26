namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GroundBattleStrategyDefinition : DatatableElement
	{

		private Prerequisite[] itemsField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private InvasionEffect[] invasionEffectField;

		private GroundBattleOpponent opponentField;


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


		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SimulationDescriptorReference
		{
			get
			{
				return this.simulationDescriptorReferenceField;
			}
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("InvasionEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InvasionEffect[] InvasionEffect
		{
			get
			{
				return this.invasionEffectField;
			}
			set
			{
				this.invasionEffectField = value;
				this.RaisePropertyChanged("InvasionEffect");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public GroundBattleOpponent Opponent
		{
			get
			{
				return this.opponentField;
			}
			set
			{
				this.opponentField = value;
				this.RaisePropertyChanged("Opponent");
			}
		}
	}
}
