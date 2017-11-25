namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DestructionModule))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class WeaponModule : Module
	{

		private Prerequisite[] items2Field;

		private XmlNamedReference salvoReferenceField;

		private AvailableRange[] availableRangeField;

		private WeaponTargetSortingCriterionDefinition[] items3Field;

		private WeaponType typeField;

		private int tierField;

		private float lineOfSightOverridenAngleField;

		public WeaponModule()
		{
			this.tierField = 1;
			this.lineOfSightOverridenAngleField = ((float)(0F));
		}


		[System.Xml.Serialization.XmlElementAttribute("AttackInterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AttackPathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AttackTechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items2
		{
			get
			{
				return this.items2Field;
			}
			set
			{
				this.items2Field = value;
				this.RaisePropertyChanged("Items2");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference SalvoReference
		{
			get
			{
				return this.salvoReferenceField;
			}
			set
			{
				this.salvoReferenceField = value;
				this.RaisePropertyChanged("SalvoReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("AvailableRange", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AvailableRange[] AvailableRange
		{
			get
			{
				return this.availableRangeField;
			}
			set
			{
				this.availableRangeField = value;
				this.RaisePropertyChanged("AvailableRange");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("TargetSortingCriterion", typeof(WeaponTargetSortingCriterionDefinition), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TargetSortingCriterion_PropertyMultiplier", typeof(WeaponTargetSortingCriterionDefinition_PropertyMultiplier), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public WeaponTargetSortingCriterionDefinition[] Items3
		{
			get
			{
				return this.items3Field;
			}
			set
			{
				this.items3Field = value;
				this.RaisePropertyChanged("Items3");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public WeaponType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int Tier
		{
			get
			{
				return this.tierField;
			}
			set
			{
				this.tierField = value;
				this.RaisePropertyChanged("Tier");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float LineOfSightOverridenAngle
		{
			get
			{
				return this.lineOfSightOverridenAngleField;
			}
			set
			{
				this.lineOfSightOverridenAngleField = value;
				this.RaisePropertyChanged("LineOfSightOverridenAngle");
			}
		}
	}
}
