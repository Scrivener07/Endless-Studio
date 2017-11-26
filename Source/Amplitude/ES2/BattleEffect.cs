namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BattleEffect_EmpireReward_SpawnShips))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BattleEffect_EmpireReward_Resource))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BattleEffect_SetStatus))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BattleEffect_SetPropertyValue))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BattleEffect_ApplyDescriptor))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleEffect : DatatableElement
	{

		private EncounterEventPrerequisiteDefinition[] cancellationEventPrerequisiteField;

		private RealizationEventByState[] realizationEventField;

		private string durationField;

		private float frequencyField;

		private StackingBehaviourType stackingBehaviourField;

		public BattleEffect()
		{
			this.durationField = "0";
			this.frequencyField = ((float)(-1F));
			this.stackingBehaviourField = StackingBehaviourType.Ignore;
		}


		[System.Xml.Serialization.XmlElementAttribute("CancellationEventPrerequisite", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEventPrerequisiteDefinition[] CancellationEventPrerequisite
		{
			get
			{
				return this.cancellationEventPrerequisiteField;
			}
			set
			{
				this.cancellationEventPrerequisiteField = value;
				this.RaisePropertyChanged("CancellationEventPrerequisite");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("RealizationEvent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RealizationEventByState[] RealizationEvent
		{
			get
			{
				return this.realizationEventField;
			}
			set
			{
				this.realizationEventField = value;
				this.RaisePropertyChanged("RealizationEvent");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("0")]
		public string Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("Duration");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "-1")]
		public float Frequency
		{
			get
			{
				return this.frequencyField;
			}
			set
			{
				this.frequencyField = value;
				this.RaisePropertyChanged("Frequency");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(StackingBehaviourType.Ignore)]
		public StackingBehaviourType StackingBehaviour
		{
			get
			{
				return this.stackingBehaviourField;
			}
			set
			{
				this.stackingBehaviourField = value;
				this.RaisePropertyChanged("StackingBehaviour");
			}
		}
	}
}
