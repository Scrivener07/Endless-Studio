namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SquadronModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BridgeModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SupportModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MothershipModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(LogisticsModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DefenseModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(WeaponModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DestructionModule))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class Module : UnlockDatatableElement
	{

		private object[] itemsField;

		private AIBattleSituation[] aIBattleSituationsField;

		private Prerequisite[] items1Field;

		private LinkedModuleEffectDefinition[] linkEffectField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private DescriptorEffectProviderWithCategory[] categorizedSimulationDescriptorsField;

		private DescriptorEffectProviderWithCategory[] categorizedSimulationDescriptorsToDisplayField;

		private XmlNamedReference[] battleActionReferenceField;

		private SlaveModuleDefinition[] slaveModuleField;

		private bool isHiddenField;

		private string familyField;

		private int levelField;

		public Module()
		{
			this.isHiddenField = false;
			this.familyField = "";
			this.levelField = 1;
		}


		[System.Xml.Serialization.XmlElementAttribute("Cost", typeof(ConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CustomCost", typeof(CustomConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object[] Items
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


		[System.Xml.Serialization.XmlElementAttribute("AIBattleSituations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AIBattleSituation[] AIBattleSituations
		{
			get
			{
				return this.aIBattleSituationsField;
			}
			set
			{
				this.aIBattleSituationsField = value;
				this.RaisePropertyChanged("AIBattleSituations");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("DownloadableContentPrerequisite", typeof(DownloadableContentPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items1
		{
			get
			{
				return this.items1Field;
			}
			set
			{
				this.items1Field = value;
				this.RaisePropertyChanged("Items1");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("LinkEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LinkedModuleEffectDefinition[] LinkEffect
		{
			get
			{
				return this.linkEffectField;
			}
			set
			{
				this.linkEffectField = value;
				this.RaisePropertyChanged("LinkEffect");
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


		[System.Xml.Serialization.XmlElementAttribute("CategorizedSimulationDescriptors", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DescriptorEffectProviderWithCategory[] CategorizedSimulationDescriptors
		{
			get
			{
				return this.categorizedSimulationDescriptorsField;
			}
			set
			{
				this.categorizedSimulationDescriptorsField = value;
				this.RaisePropertyChanged("CategorizedSimulationDescriptors");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DescriptorEffectProviderWithCategory[] CategorizedSimulationDescriptorsToDisplay
		{
			get
			{
				return this.categorizedSimulationDescriptorsToDisplayField;
			}
			set
			{
				this.categorizedSimulationDescriptorsToDisplayField = value;
				this.RaisePropertyChanged("CategorizedSimulationDescriptorsToDisplay");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("BattleActionReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] BattleActionReference
		{
			get
			{
				return this.battleActionReferenceField;
			}
			set
			{
				this.battleActionReferenceField = value;
				this.RaisePropertyChanged("BattleActionReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("SlaveModule", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlaveModuleDefinition[] SlaveModule
		{
			get
			{
				return this.slaveModuleField;
			}
			set
			{
				this.slaveModuleField = value;
				this.RaisePropertyChanged("SlaveModule");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsHidden
		{
			get
			{
				return this.isHiddenField;
			}
			set
			{
				this.isHiddenField = value;
				this.RaisePropertyChanged("IsHidden");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string Family
		{
			get
			{
				return this.familyField;
			}
			set
			{
				this.familyField = value;
				this.RaisePropertyChanged("Family");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int Level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("Level");
			}
		}
	}
}
