


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DiplomaticAbilityWhenActive : object, System.ComponentModel.INotifyPropertyChanged
{

	private string nameField;

	private ApplicationMode applyOnField;


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
	public ApplicationMode ApplyOn
	{
		get
		{
			return this.applyOnField;
		}
		set
		{
			this.applyOnField = value;
			this.RaisePropertyChanged("ApplyOn");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum ApplicationMode
{


	Symmetrical,


	FirstEmpireTowardsSecondEmpire,


	SecondEmpireTowardsFirstEmpire,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ConstructionCost : object, System.ComponentModel.INotifyPropertyChanged
{

	private bool instantField;

	private bool instantOnCompletionField;

	private string resourceNameField;

	private float valueField;

	public ConstructionCost()
	{
		this.instantField = false;
		this.instantOnCompletionField = false;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool Instant
	{
		get
		{
			return this.instantField;
		}
		set
		{
			this.instantField = value;
			this.RaisePropertyChanged("Instant");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool InstantOnCompletion
	{
		get
		{
			return this.instantOnCompletionField;
		}
		set
		{
			this.instantOnCompletionField = value;
			this.RaisePropertyChanged("InstantOnCompletion");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string ResourceName
	{
		get
		{
			return this.resourceNameField;
		}
		set
		{
			this.resourceNameField = value;
			this.RaisePropertyChanged("ResourceName");
		}
	}


	[System.Xml.Serialization.XmlTextAttribute()]
	public float Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
			this.RaisePropertyChanged("Value");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CustomConstructionCost : object, System.ComponentModel.INotifyPropertyChanged
{

	private bool instantField;

	private bool instantOnCompletionField;

	private string resourceNameField;

	private string valueField;

	public CustomConstructionCost()
	{
		this.instantField = false;
		this.instantOnCompletionField = false;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool Instant
	{
		get
		{
			return this.instantField;
		}
		set
		{
			this.instantField = value;
			this.RaisePropertyChanged("Instant");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool InstantOnCompletion
	{
		get
		{
			return this.instantOnCompletionField;
		}
		set
		{
			this.instantOnCompletionField = value;
			this.RaisePropertyChanged("InstantOnCompletion");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string ResourceName
	{
		get
		{
			return this.resourceNameField;
		}
		set
		{
			this.resourceNameField = value;
			this.RaisePropertyChanged("ResourceName");
		}
	}


	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
			this.RaisePropertyChanged("Value");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TributeDefinition : object, System.ComponentModel.INotifyPropertyChanged
{

	private string resourceNameField;

	private int percentageField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string ResourceName
	{
		get
		{
			return this.resourceNameField;
		}
		set
		{
			this.resourceNameField = value;
			this.RaisePropertyChanged("ResourceName");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int Percentage
	{
		get
		{
			return this.percentageField;
		}
		set
		{
			this.percentageField = value;
			this.RaisePropertyChanged("Percentage");
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





[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_CancelLeechActions))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_DisplaySubEffects))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RemoveFleetsFromInfluence))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RemoveNeighbours))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RemoveSpaceRoots))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RemoveTimeBubbles))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ResetEmpireHistory))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ResetInfluenceConversion))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ResetPressure))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RestrictInteraction))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RestrictAttack))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermSubDynamicEffect))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ApplyDiplomaticPressureEffect))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTerm))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTribute))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_HeroLock))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_MinorFactionTransfer))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_PopulationMigration))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ApplyTemporaryEffect))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect : object, System.ComponentModel.INotifyPropertyChanged
{

	private bool hiddenField;

	private string guiCategoryField;

	public ContextualDiplomaticTermEffect()
	{
		this.hiddenField = false;
		this.guiCategoryField = "CategoryTreaty";
	}


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


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute("CategoryTreaty")]
	public string GuiCategory
	{
		get
		{
			return this.guiCategoryField;
		}
		set
		{
			this.guiCategoryField = value;
			this.RaisePropertyChanged("GuiCategory");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_CancelLeechActions : ContextualDiplomaticTermEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_DisplaySubEffects : ContextualDiplomaticTermEffect
{

	private string descriptionField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Description
	{
		get
		{
			return this.descriptionField;
		}
		set
		{
			this.descriptionField = value;
			this.RaisePropertyChanged("Description");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RemoveFleetsFromInfluence : ContextualDiplomaticTermEffect
{

	private Prerequisite[] itemsField;

	private MetaPrerequisite[] metaPrerequisiteField;


	[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
}














[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RemoveNeighbours : ContextualDiplomaticTermEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RemoveSpaceRoots : ContextualDiplomaticTermEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RemoveTimeBubbles : ContextualDiplomaticTermEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_ResetEmpireHistory : ContextualDiplomaticTermEffect
{

	private bool resetAttackField;

	private bool resetColonizationField;

	public ContextualDiplomaticTermEffect_ResetEmpireHistory()
	{
		this.resetAttackField = false;
		this.resetColonizationField = false;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool ResetAttack
	{
		get
		{
			return this.resetAttackField;
		}
		set
		{
			this.resetAttackField = value;
			this.RaisePropertyChanged("ResetAttack");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool ResetColonization
	{
		get
		{
			return this.resetColonizationField;
		}
		set
		{
			this.resetColonizationField = value;
			this.RaisePropertyChanged("ResetColonization");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_ResetInfluenceConversion : ContextualDiplomaticTermEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_ResetPressure : ContextualDiplomaticTermEffect
{
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_RestrictAttack))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RestrictInteraction : ContextualDiplomaticTermEffect
{

	private int durationField;

	private string propertyNameField;

	private string descriptionField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int Duration
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
	public string PropertyName
	{
		get
		{
			return this.propertyNameField;
		}
		set
		{
			this.propertyNameField = value;
			this.RaisePropertyChanged("PropertyName");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Description
	{
		get
		{
			return this.descriptionField;
		}
		set
		{
			this.descriptionField = value;
			this.RaisePropertyChanged("Description");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_RestrictAttack : ContextualDiplomaticTermEffect_RestrictInteraction
{
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ApplyDiplomaticPressureEffect))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTerm))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTribute))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_HeroLock))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_MinorFactionTransfer))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermDynamicEffect_PopulationMigration))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermEffect_ApplyTemporaryEffect))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermSubDynamicEffect : ContextualDiplomaticTermEffect
{

	private string nameField;


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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_ApplyDiplomaticPressureEffect : ContextualDiplomaticTermSubDynamicEffect
{

	private XmlNamedReference diplomaticPressureEffectReferenceField;

	private DiplomaticEffectTargetType targetField;


	[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public XmlNamedReference DiplomaticPressureEffectReference
	{
		get
		{
			return this.diplomaticPressureEffectReferenceField;
		}
		set
		{
			this.diplomaticPressureEffectReferenceField = value;
			this.RaisePropertyChanged("DiplomaticPressureEffectReference");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public DiplomaticEffectTargetType Target
	{
		get
		{
			return this.targetField;
		}
		set
		{
			this.targetField = value;
			this.RaisePropertyChanged("Target");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum DiplomaticEffectTargetType
{


	CurrentEmpire,


	CurrentEmpireOnOtherEmpires,


	OtherEmpireOnOtherEmpires,


	CurrentEmpireOnOtherEmpiresAndOtherEmpire,


	OtherEmpireOnOtherEmpiresAndChooserEmpire,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect_DiplomaticTerm : ContextualDiplomaticTermSubDynamicEffect
{

	private XmlNamedReference[] diplomaticTermReferenceField;


	[System.Xml.Serialization.XmlElementAttribute("DiplomaticTermReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public XmlNamedReference[] DiplomaticTermReference
	{
		get
		{
			return this.diplomaticTermReferenceField;
		}
		set
		{
			this.diplomaticTermReferenceField = value;
			this.RaisePropertyChanged("DiplomaticTermReference");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect_DiplomaticTribute : ContextualDiplomaticTermSubDynamicEffect
{

	private TributeDefinition[] tributeField;

	private int durationField;


	[System.Xml.Serialization.XmlElementAttribute("Tribute", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public TributeDefinition[] Tribute
	{
		get
		{
			return this.tributeField;
		}
		set
		{
			this.tributeField = value;
			this.RaisePropertyChanged("Tribute");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int Duration
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect_HeroLock : ContextualDiplomaticTermSubDynamicEffect
{

	private int durationField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int Duration
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect_MinorFactionTransfer : ContextualDiplomaticTermSubDynamicEffect
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect_PopulationMigration : ContextualDiplomaticTermSubDynamicEffect
{

	private int populationCountField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int PopulationCount
	{
		get
		{
			return this.populationCountField;
		}
		set
		{
			this.populationCountField = value;
			this.RaisePropertyChanged("PopulationCount");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermEffect_ApplyTemporaryEffect : ContextualDiplomaticTermSubDynamicEffect
{

	private XmlNamedReference temporaryEffectReferenceField;

	private TemporaryEffectTargetType targetField;


	[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public XmlNamedReference TemporaryEffectReference
	{
		get
		{
			return this.temporaryEffectReferenceField;
		}
		set
		{
			this.temporaryEffectReferenceField = value;
			this.RaisePropertyChanged("TemporaryEffectReference");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public TemporaryEffectTargetType Target
	{
		get
		{
			return this.targetField;
		}
		set
		{
			this.targetField = value;
			this.RaisePropertyChanged("Target");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum TemporaryEffectTargetType
{


	CurrentEmpire,


	OtherEmpire,


	Context,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermDynamicEffect : ContextualDiplomaticTermEffect
{

	private ContextualDiplomaticTermSubDynamicEffect[] itemsField;

	private string nameField;

	private ApplicationMethod applicationMethodField;


	[System.Xml.Serialization.XmlElementAttribute("Effect_DiplomaticEffect", typeof(ContextualDiplomaticTermEffect_ApplyDiplomaticPressureEffect), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_DiplomaticTerm", typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTerm), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_DiplomaticTribute", typeof(ContextualDiplomaticTermDynamicEffect_DiplomaticTribute), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_HeroLock", typeof(ContextualDiplomaticTermDynamicEffect_HeroLock), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_MinorFactionTransfer", typeof(ContextualDiplomaticTermDynamicEffect_MinorFactionTransfer), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_PopulationMigration", typeof(ContextualDiplomaticTermDynamicEffect_PopulationMigration), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_TemporaryEffect", typeof(ContextualDiplomaticTermEffect_ApplyTemporaryEffect), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public ContextualDiplomaticTermSubDynamicEffect[] Items
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
	public ApplicationMethod ApplicationMethod
	{
		get
		{
			return this.applicationMethodField;
		}
		set
		{
			this.applicationMethodField = value;
			this.RaisePropertyChanged("ApplicationMethod");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum ApplicationMethod
{


	ReceiverOnly,


	ProviderOnly,


	Symmetrical,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermChoice : object, System.ComponentModel.INotifyPropertyChanged
{

	private Prerequisite[] itemsField;

	private MetaPrerequisite[] metaPrerequisiteField;

	private object[] items1Field;

	private ContextualDiplomaticTermEffect[] items2Field;

	private XmlNamedReference resultingTermReferenceField;

	private XmlNamedReference[] populationEventField;

	private object[] items3Field;

	private bool isPositiveField;

	private string nameField;


	[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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


	[System.Xml.Serialization.XmlElementAttribute("DiplomaticAbilityPrerequisite", typeof(DiplomaticAbilityPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("DiplomaticMetaPrerequisite", typeof(SimpleDiplomaticMetaPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("DiplomaticRelationStatePrerequisite", typeof(DiplomaticRelationStatePrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public object[] Items1
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


	[System.Xml.Serialization.XmlElementAttribute("DynamicEffect", typeof(ContextualDiplomaticTermDynamicEffect), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_ApplyDiplomaticEffect", typeof(ContextualDiplomaticTermEffect_ApplyDiplomaticPressureEffect), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_ApplyTemporaryEffect", typeof(ContextualDiplomaticTermEffect_ApplyTemporaryEffect), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_CancelLeechActions", typeof(ContextualDiplomaticTermEffect_CancelLeechActions), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_DisplaySubEffects", typeof(ContextualDiplomaticTermEffect_DisplaySubEffects), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RemoveFleetsFromInfluence", typeof(ContextualDiplomaticTermEffect_RemoveFleetsFromInfluence), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RemoveNeighbours", typeof(ContextualDiplomaticTermEffect_RemoveNeighbours), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RemoveSpaceRoots", typeof(ContextualDiplomaticTermEffect_RemoveSpaceRoots), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RemoveTimeBubbles", typeof(ContextualDiplomaticTermEffect_RemoveTimeBubbles), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_ResetEmpireHistory", typeof(ContextualDiplomaticTermEffect_ResetEmpireHistory), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_ResetInfluenceConversion", typeof(ContextualDiplomaticTermEffect_ResetInfluenceConversion), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_ResetPressure", typeof(ContextualDiplomaticTermEffect_ResetPressure), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RestrictAttack", typeof(ContextualDiplomaticTermEffect_RestrictAttack), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Effect_RestrictInteraction", typeof(ContextualDiplomaticTermEffect_RestrictInteraction), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public ContextualDiplomaticTermEffect[] Items2
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
	public XmlNamedReference ResultingTermReference
	{
		get
		{
			return this.resultingTermReferenceField;
		}
		set
		{
			this.resultingTermReferenceField = value;
			this.RaisePropertyChanged("ResultingTermReference");
		}
	}


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


	[System.Xml.Serialization.XmlElementAttribute("Cost", typeof(ConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("CustomCost", typeof(CustomConstructionCost), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public object[] Items3
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
	public bool IsPositive
	{
		get
		{
			return this.isPositiveField;
		}
		set
		{
			this.isPositiveField = value;
			this.RaisePropertyChanged("IsPositive");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DiplomaticAbilityPrerequisite : DiplomaticPrerequisite
{

	private PrerequisiteTargetRelation targetRelationField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public PrerequisiteTargetRelation TargetRelation
	{
		get
		{
			return this.targetRelationField;
		}
		set
		{
			this.targetRelationField = value;
			this.RaisePropertyChanged("TargetRelation");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum PrerequisiteTargetRelation
{


	ReceiverToProvider,


	ProviderToReceiver,
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticRelationStatePrerequisite))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticAbilityPrerequisite))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DiplomaticPrerequisite : object, System.ComponentModel.INotifyPropertyChanged
{

	private bool invertedField;

	private string flagsField;

	private string valueField;

	public DiplomaticPrerequisite()
	{
		this.invertedField = false;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool Inverted
	{
		get
		{
			return this.invertedField;
		}
		set
		{
			this.invertedField = value;
			this.RaisePropertyChanged("Inverted");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Flags
	{
		get
		{
			return this.flagsField;
		}
		set
		{
			this.flagsField = value;
			this.RaisePropertyChanged("Flags");
		}
	}


	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
			this.RaisePropertyChanged("Value");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DiplomaticRelationStatePrerequisite : DiplomaticPrerequisite
{

	private DiplomaticCostResponsible responsibleField;

	public DiplomaticRelationStatePrerequisite()
	{
		this.responsibleField = DiplomaticCostResponsible.EmpireWhichProvides;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(DiplomaticCostResponsible.EmpireWhichProvides)]
	public DiplomaticCostResponsible Responsible
	{
		get
		{
			return this.responsibleField;
		}
		set
		{
			this.responsibleField = value;
			this.RaisePropertyChanged("Responsible");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum DiplomaticCostResponsible
{


	EmpireWhichProposes,


	EmpireWhichProvides,


	EmpireWhichReceives,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SimpleDiplomaticMetaPrerequisite : object, System.ComponentModel.INotifyPropertyChanged
{

	private DiplomaticPrerequisite[] itemsField;

	private OperatorType operatorField;

	private bool invertedField;

	private string flagsField;

	public SimpleDiplomaticMetaPrerequisite()
	{
		this.invertedField = false;
	}


	[System.Xml.Serialization.XmlElementAttribute("DiplomaticAbilityPrerequisite", typeof(DiplomaticAbilityPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("DiplomaticRelationStatePrerequisite", typeof(DiplomaticRelationStatePrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public DiplomaticPrerequisite[] Items
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


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public OperatorType Operator
	{
		get
		{
			return this.operatorField;
		}
		set
		{
			this.operatorField = value;
			this.RaisePropertyChanged("Operator");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(false)]
	public bool Inverted
	{
		get
		{
			return this.invertedField;
		}
		set
		{
			this.invertedField = value;
			this.RaisePropertyChanged("Inverted");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string Flags
	{
		get
		{
			return this.flagsField;
		}
		set
		{
			this.flagsField = value;
			this.RaisePropertyChanged("Flags");
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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum OperatorType
{


	OR,


	XOR,


	NOR,


	AND,


	NAND,
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_FleetsInInfluence))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_Pressure))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_SystemsLeeched))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_SystemsRooted))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_SystemsUnderConversion))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermCondition_TimeBubblesOnSystems))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_FleetsDestroyed))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_NeighboursColonized))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_NeighboursExploited))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition : object, System.ComponentModel.INotifyPropertyChanged
{

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


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_FleetsInInfluence : ContextualDiplomaticTermCondition
{

	private Prerequisite[] itemsField;

	private MetaPrerequisite[] metaPrerequisiteField;


	[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_Pressure : ContextualDiplomaticTermCondition
{

	private int minimumField;

	private int maximumField;

	public ContextualDiplomaticTermCondition_Pressure()
	{
		this.maximumField = 2147483647;
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int Minimum
	{
		get
		{
			return this.minimumField;
		}
		set
		{
			this.minimumField = value;
			this.RaisePropertyChanged("Minimum");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(2147483647)]
	public int Maximum
	{
		get
		{
			return this.maximumField;
		}
		set
		{
			this.maximumField = value;
			this.RaisePropertyChanged("Maximum");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_SystemsLeeched : ContextualDiplomaticTermCondition
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_SystemsRooted : ContextualDiplomaticTermCondition
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_SystemsUnderConversion : ContextualDiplomaticTermCondition
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermCondition_TimeBubblesOnSystems : ContextualDiplomaticTermCondition
{
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_FleetsDestroyed))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_NeighboursColonized))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContextualDiplomaticTermConditionTimer_NeighboursExploited))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermConditionTimer : ContextualDiplomaticTermCondition
{

	private int maximumDelayField;


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public int MaximumDelay
	{
		get
		{
			return this.maximumDelayField;
		}
		set
		{
			this.maximumDelayField = value;
			this.RaisePropertyChanged("MaximumDelay");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermConditionTimer_FleetsDestroyed : ContextualDiplomaticTermConditionTimer
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermConditionTimer_NeighboursColonized : ContextualDiplomaticTermConditionTimer
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ContextualDiplomaticTermConditionTimer_NeighboursExploited : ContextualDiplomaticTermConditionTimer
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
public partial class ContextualDiplomaticTermDefinition : DatatableElement
{

	private Prerequisite[] itemsField;

	private MetaPrerequisite[] metaPrerequisiteField;

	private object[] items1Field;

	private ContextualDiplomaticTermCondition[] items2Field;

	private ContextualDiplomaticTermChoice[] choiceField;

	private DiplomaticAbilityWhenActive[] diplomaticAbilityWhenActiveField;

	private bool isSubtermField;

	private string autoSelectedProviderDynamicEffectField;

	private string defaultChoiceNameField;

	private int cooldownField;

	private WarDeclarationType cancelOnWarDeclarationField;

	public ContextualDiplomaticTermDefinition()
	{
		this.cooldownField = 0;
		this.cancelOnWarDeclarationField = WarDeclarationType.Both;
	}


	[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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


	[System.Xml.Serialization.XmlElementAttribute("DiplomaticAbilityPrerequisite", typeof(DiplomaticAbilityPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("DiplomaticMetaPrerequisite", typeof(SimpleDiplomaticMetaPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("DiplomaticRelationStatePrerequisite", typeof(DiplomaticRelationStatePrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public object[] Items1
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


	[System.Xml.Serialization.XmlElementAttribute("Condition_FleetsDestroyed", typeof(ContextualDiplomaticTermConditionTimer_FleetsDestroyed), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_FleetsInInfluence", typeof(ContextualDiplomaticTermCondition_FleetsInInfluence), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_NeighboursColonized", typeof(ContextualDiplomaticTermConditionTimer_NeighboursColonized), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_NeighboursExploited", typeof(ContextualDiplomaticTermConditionTimer_NeighboursExploited), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_Pressure", typeof(ContextualDiplomaticTermCondition_Pressure), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_SystemsLeeched", typeof(ContextualDiplomaticTermCondition_SystemsLeeched), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_SystemsRooted", typeof(ContextualDiplomaticTermCondition_SystemsRooted), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_SystemsUnderConversion", typeof(ContextualDiplomaticTermCondition_SystemsUnderConversion), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	[System.Xml.Serialization.XmlElementAttribute("Condition_TimeBubblesOnSystems", typeof(ContextualDiplomaticTermCondition_TimeBubblesOnSystems), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public ContextualDiplomaticTermCondition[] Items2
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


	[System.Xml.Serialization.XmlElementAttribute("Choice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public ContextualDiplomaticTermChoice[] Choice
	{
		get
		{
			return this.choiceField;
		}
		set
		{
			this.choiceField = value;
			this.RaisePropertyChanged("Choice");
		}
	}


	[System.Xml.Serialization.XmlElementAttribute("DiplomaticAbilityWhenActive", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
	public DiplomaticAbilityWhenActive[] DiplomaticAbilityWhenActive
	{
		get
		{
			return this.diplomaticAbilityWhenActiveField;
		}
		set
		{
			this.diplomaticAbilityWhenActiveField = value;
			this.RaisePropertyChanged("DiplomaticAbilityWhenActive");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool IsSubterm
	{
		get
		{
			return this.isSubtermField;
		}
		set
		{
			this.isSubtermField = value;
			this.RaisePropertyChanged("IsSubterm");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string AutoSelectedProviderDynamicEffect
	{
		get
		{
			return this.autoSelectedProviderDynamicEffectField;
		}
		set
		{
			this.autoSelectedProviderDynamicEffectField = value;
			this.RaisePropertyChanged("AutoSelectedProviderDynamicEffect");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string DefaultChoiceName
	{
		get
		{
			return this.defaultChoiceNameField;
		}
		set
		{
			this.defaultChoiceNameField = value;
			this.RaisePropertyChanged("DefaultChoiceName");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(0)]
	public int Cooldown
	{
		get
		{
			return this.cooldownField;
		}
		set
		{
			this.cooldownField = value;
			this.RaisePropertyChanged("Cooldown");
		}
	}


	[System.Xml.Serialization.XmlAttributeAttribute()]
	[System.ComponentModel.DefaultValueAttribute(WarDeclarationType.Both)]
	public WarDeclarationType CancelOnWarDeclaration
	{
		get
		{
			return this.cancelOnWarDeclarationField;
		}
		set
		{
			this.cancelOnWarDeclarationField = value;
			this.RaisePropertyChanged("CancelOnWarDeclaration");
		}
	}
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum WarDeclarationType
{


	Disabled,


	SenderOnly,


	Both,


	ReceiverOnly,
}
