namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(WeaponSlotDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SlotDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private object[] itemsField;

		private CostReductionReference[] costReductionReferenceField;

		private Prerequisite[] items1Field;

		private ModuleCategory[] restrictedModuleCategoryField;

		private LineOfSight[] lineOfSightField;

		private SerializableDirection directionField;

		private float angleField;

		private XmlNamedReference defaultModuleReferenceField;

		private SlotEditingListener[] listenerSlotField;

		private ModuleModifierDefinition[] moduleModifierField;

		private string uISlotNameField;

		private string[] visualSlotNameField;

		private int moduleCostMultiplierField;

		private string nameField;

		private bool isLargeSlotField;

		private bool isEditableField;

		private float effectMultiplierField;

		private bool isHiddenField;

		private bool showPositionMarkerField;

		private float positionMarkerAngleField;

		public SlotDefinition()
		{
			this.angleField = ((float)(90F));
			this.moduleCostMultiplierField = 1;
			this.isLargeSlotField = false;
			this.isEditableField = true;
			this.effectMultiplierField = ((float)(1F));
			this.isHiddenField = false;
			this.showPositionMarkerField = false;
			this.positionMarkerAngleField = ((float)(0F));
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


		[System.Xml.Serialization.XmlElementAttribute("RestrictedModuleCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ModuleCategory[] RestrictedModuleCategory
		{
			get
			{
				return this.restrictedModuleCategoryField;
			}
			set
			{
				this.restrictedModuleCategoryField = value;
				this.RaisePropertyChanged("RestrictedModuleCategory");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("LineOfSight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LineOfSight[] LineOfSight
		{
			get
			{
				return this.lineOfSightField;
			}
			set
			{
				this.lineOfSightField = value;
				this.RaisePropertyChanged("LineOfSight");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableDirection Direction
		{
			get
			{
				return this.directionField;
			}
			set
			{
				this.directionField = value;
				this.RaisePropertyChanged("Direction");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "90")]
		public float Angle
		{
			get
			{
				return this.angleField;
			}
			set
			{
				this.angleField = value;
				this.RaisePropertyChanged("Angle");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference DefaultModuleReference
		{
			get
			{
				return this.defaultModuleReferenceField;
			}
			set
			{
				this.defaultModuleReferenceField = value;
				this.RaisePropertyChanged("DefaultModuleReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ListenerSlot", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotEditingListener[] ListenerSlot
		{
			get
			{
				return this.listenerSlotField;
			}
			set
			{
				this.listenerSlotField = value;
				this.RaisePropertyChanged("ListenerSlot");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ModuleModifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ModuleModifierDefinition[] ModuleModifier
		{
			get
			{
				return this.moduleModifierField;
			}
			set
			{
				this.moduleModifierField = value;
				this.RaisePropertyChanged("ModuleModifier");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UISlotName
		{
			get
			{
				return this.uISlotNameField;
			}
			set
			{
				this.uISlotNameField = value;
				this.RaisePropertyChanged("UISlotName");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("VisualSlotName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] VisualSlotName
		{
			get
			{
				return this.visualSlotNameField;
			}
			set
			{
				this.visualSlotNameField = value;
				this.RaisePropertyChanged("VisualSlotName");
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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsLargeSlot
		{
			get
			{
				return this.isLargeSlotField;
			}
			set
			{
				this.isLargeSlotField = value;
				this.RaisePropertyChanged("IsLargeSlot");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool IsEditable
		{
			get
			{
				return this.isEditableField;
			}
			set
			{
				this.isEditableField = value;
				this.RaisePropertyChanged("IsEditable");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float EffectMultiplier
		{
			get
			{
				return this.effectMultiplierField;
			}
			set
			{
				this.effectMultiplierField = value;
				this.RaisePropertyChanged("EffectMultiplier");
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
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ShowPositionMarker
		{
			get
			{
				return this.showPositionMarkerField;
			}
			set
			{
				this.showPositionMarkerField = value;
				this.RaisePropertyChanged("ShowPositionMarker");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float PositionMarkerAngle
		{
			get
			{
				return this.positionMarkerAngleField;
			}
			set
			{
				this.positionMarkerAngleField = value;
				this.RaisePropertyChanged("PositionMarkerAngle");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
