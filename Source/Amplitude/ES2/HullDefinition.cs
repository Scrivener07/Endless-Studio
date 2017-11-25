namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class HullDefinition : UnlockDatatableElement
	{

		private float buyoutCostModifierField;

		private Tags tagsField;

		private CostReductionReference[] costReductionReferenceField;

		private object[] itemsField;

		private Prerequisite[] items1Field;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private ShipDesignLayoutDefinition[] shipDesignLayoutField;

		private XmlNamedReference[] battleActionReferenceField;

		private XmlNamedReference levelUpRuleReferenceField;

		private string categoryField;

		private string subCategoryField;

		private int moduleCostMultiplierField;

		private string representativeMappingOverrideField;

		private string scoreProviderField;

		private bool isMothershipField;

		public HullDefinition()
		{
			this.buyoutCostModifierField = ((float)(0F));
			this.moduleCostMultiplierField = 1;
			this.isMothershipField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float BuyoutCostModifier
		{
			get
			{
				return this.buyoutCostModifierField;
			}
			set
			{
				this.buyoutCostModifierField = value;
				this.RaisePropertyChanged("BuyoutCostModifier");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get
			{
				return this.tagsField;
			}
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("CostReductionReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CostReductionReference[] CostReductionReference
		{
			get
			{
				return this.costReductionReferenceField;
			}
			set
			{
				this.costReductionReferenceField = value;
				this.RaisePropertyChanged("CostReductionReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Cost", typeof(ConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CustomCost", typeof(CustomConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InfiniteCost", typeof(InfiniteCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SupportPrerequisite", typeof(SupportPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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


		[System.Xml.Serialization.XmlElementAttribute("ShipDesignLayout", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ShipDesignLayoutDefinition[] ShipDesignLayout
		{
			get
			{
				return this.shipDesignLayoutField;
			}
			set
			{
				this.shipDesignLayoutField = value;
				this.RaisePropertyChanged("ShipDesignLayout");
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


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference LevelUpRuleReference
		{
			get
			{
				return this.levelUpRuleReferenceField;
			}
			set
			{
				this.levelUpRuleReferenceField = value;
				this.RaisePropertyChanged("LevelUpRuleReference");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SubCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
				this.RaisePropertyChanged("SubCategory");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int ModuleCostMultiplier
		{
			get
			{
				return this.moduleCostMultiplierField;
			}
			set
			{
				this.moduleCostMultiplierField = value;
				this.RaisePropertyChanged("ModuleCostMultiplier");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string RepresentativeMappingOverride
		{
			get
			{
				return this.representativeMappingOverrideField;
			}
			set
			{
				this.representativeMappingOverrideField = value;
				this.RaisePropertyChanged("RepresentativeMappingOverride");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ScoreProvider
		{
			get
			{
				return this.scoreProviderField;
			}
			set
			{
				this.scoreProviderField = value;
				this.RaisePropertyChanged("ScoreProvider");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsMothership
		{
			get
			{
				return this.isMothershipField;
			}
			set
			{
				this.isMothershipField = value;
				this.RaisePropertyChanged("IsMothership");
			}
		}
	}
}
