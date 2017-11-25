namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnomalyReductionDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ConstructibleElement : UnlockDatatableElement
	{

		private AIGain[] aIGainField;

		private SupervisorGain[] supervisorGainField;

		private float buyoutCostModifierField;

		private Tags tagsField;

		private SimulationDescriptorReference[] inProgressSimulationDescriptorReferenceField;

		private SimulationDescriptorReference[] queuedSimulationDescriptorReferenceField;

		private XmlNamedReference constructionQueueEntityActionReferenceField;

		private CostReductionReference[] costReductionReferenceField;

		private object[] itemsField;

		private Prerequisite[] items1Field;

		private MetaPrerequisite[] metaPrerequisiteField;

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private XmlNamedReference[] populationEventField;

		private bool stackableField;

		private string categoryField;

		private string subCategoryField;

		private string scoreProviderField;

		private bool hiddenField;

		private bool consumeResourceSurplusField;

		public ConstructibleElement()
		{
			this.buyoutCostModifierField = ((float)(0F));
			this.stackableField = false;
			this.hiddenField = false;
			this.consumeResourceSurplusField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AIGain", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AIGain[] AIGain
		{
			get
			{
				return this.aIGainField;
			}
			set
			{
				this.aIGainField = value;
				this.RaisePropertyChanged("AIGain");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SupervisorGain", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SupervisorGain[] SupervisorGain
		{
			get
			{
				return this.supervisorGainField;
			}
			set
			{
				this.supervisorGainField = value;
				this.RaisePropertyChanged("SupervisorGain");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InProgressSimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] InProgressSimulationDescriptorReference
		{
			get
			{
				return this.inProgressSimulationDescriptorReferenceField;
			}
			set
			{
				this.inProgressSimulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("InProgressSimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("QueuedSimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] QueuedSimulationDescriptorReference
		{
			get
			{
				return this.queuedSimulationDescriptorReferenceField;
			}
			set
			{
				this.queuedSimulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("QueuedSimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference ConstructionQueueEntityActionReference
		{
			get
			{
				return this.constructionQueueEntityActionReferenceField;
			}
			set
			{
				this.constructionQueueEntityActionReferenceField = value;
				this.RaisePropertyChanged("ConstructionQueueEntityActionReference");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DownloadableContentPrerequisite", typeof(DownloadableContentPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MetaPrerequisite", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MetaPrerequisite[] MetaPrerequisite
		{
			get
			{
				return this.metaPrerequisiteField;
			}
			set
			{
				this.metaPrerequisiteField = value;
				this.RaisePropertyChanged("MetaPrerequisite");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PopulationEvent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] PopulationEvent
		{
			get
			{
				return this.populationEventField;
			}
			set
			{
				this.populationEventField = value;
				this.RaisePropertyChanged("PopulationEvent");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Stackable
		{
			get
			{
				return this.stackableField;
			}
			set
			{
				this.stackableField = value;
				this.RaisePropertyChanged("Stackable");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
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

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
				this.RaisePropertyChanged("Hidden");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ConsumeResourceSurplus
		{
			get
			{
				return this.consumeResourceSurplusField;
			}
			set
			{
				this.consumeResourceSurplusField = value;
				this.RaisePropertyChanged("ConsumeResourceSurplus");
			}
		}
	}
}
