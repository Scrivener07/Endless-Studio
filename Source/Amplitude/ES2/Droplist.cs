﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8762
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Droplist))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DatatableElement : object, System.ComponentModel.INotifyPropertyChanged {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
    
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    protected void RaisePropertyChanged(string propertyName) {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null)) {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfDroplist))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceList))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableString))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableInteger))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableResource))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableFleet))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfTechnologyDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceTechnology))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableBlueprint))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableModule))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceLaw))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfHeroDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceHero))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfUnlockDatatableElement))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceUnlock))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfEncounterPlayDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferencePlay))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableFaction))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Droppable : object, System.ComponentModel.INotifyPropertyChanged {
    
    private bool canHaveDuplicateField;
    
    private int weightField;
    
    private int maxTurnField;
    
    public Droppable() {
        this.canHaveDuplicateField = true;
        this.weightField = 1;
        this.maxTurnField = 0;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool CanHaveDuplicate {
        get {
            return this.canHaveDuplicateField;
        }
        set {
            this.canHaveDuplicateField = value;
            this.RaisePropertyChanged("CanHaveDuplicate");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int Weight {
        get {
            return this.weightField;
        }
        set {
            this.weightField = value;
            this.RaisePropertyChanged("Weight");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxTurn {
        get {
            return this.maxTurnField;
        }
        set {
            this.maxTurnField = value;
            this.RaisePropertyChanged("MaxTurn");
        }
    }
    
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    protected void RaisePropertyChanged(string propertyName) {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null)) {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceList))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceOfDroplist : Droppable {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceList : DroppableReferenceOfDroplist {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableString : Droppable {
    
    private string valueField;
    
    private string descriptionField;
    
    public DroppableString() {
        this.descriptionField = "";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
            this.RaisePropertyChanged("Value");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
            this.RaisePropertyChanged("Description");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableInteger : Droppable {
    
    private int valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
            this.RaisePropertyChanged("Value");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableResource : Droppable {
    
    private int quantityField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
            this.RaisePropertyChanged("Quantity");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableFleet : Droppable {
    
    private string heroDefinitionField;
    
    private string[] shipDesignField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string HeroDefinition {
        get {
            return this.heroDefinitionField;
        }
        set {
            this.heroDefinitionField = value;
            this.RaisePropertyChanged("HeroDefinition");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShipDesign", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string[] ShipDesign {
        get {
            return this.shipDesignField;
        }
        set {
            this.shipDesignField = value;
            this.RaisePropertyChanged("ShipDesign");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceTechnology))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableBlueprint))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableModule))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceLaw))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceOfTechnologyDefinition : Droppable {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableBlueprint))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableModule))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceTechnology : DroppableReferenceOfTechnologyDefinition {
    
    private bool constrainedField;
    
    public DroppableReferenceTechnology() {
        this.constrainedField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Constrained {
        get {
            return this.constrainedField;
        }
        set {
            this.constrainedField = value;
            this.RaisePropertyChanged("Constrained");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableBlueprint : DroppableReferenceTechnology {
    
    private string constructibleNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ConstructibleName {
        get {
            return this.constructibleNameField;
        }
        set {
            this.constructibleNameField = value;
            this.RaisePropertyChanged("ConstructibleName");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableModule : DroppableReferenceTechnology {
    
    private string moduleNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ModuleName {
        get {
            return this.moduleNameField;
        }
        set {
            this.moduleNameField = value;
            this.RaisePropertyChanged("ModuleName");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceLaw : DroppableReferenceOfTechnologyDefinition {
    
    private bool constrainedField;
    
    public DroppableReferenceLaw() {
        this.constrainedField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Constrained {
        get {
            return this.constrainedField;
        }
        set {
            this.constrainedField = value;
            this.RaisePropertyChanged("Constrained");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceHero))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceOfHeroDefinition : Droppable {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceHero : DroppableReferenceOfHeroDefinition {
    
    private bool spawnField;
    
    private int levelField;
    
    public DroppableReferenceHero() {
        this.spawnField = false;
        this.levelField = 1;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Spawn {
        get {
            return this.spawnField;
        }
        set {
            this.spawnField = value;
            this.RaisePropertyChanged("Spawn");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int Level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
            this.RaisePropertyChanged("Level");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceUnlock))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceOfUnlockDatatableElement : Droppable {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceUnlock : DroppableReferenceOfUnlockDatatableElement {
    
    private string simulationDescriptorReferenceField;
    
    private string simulationTagField;
    
    private bool constrainedField;
    
    private bool applyOnEmpireField;
    
    public DroppableReferenceUnlock() {
        this.constrainedField = true;
        this.applyOnEmpireField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SimulationDescriptorReference {
        get {
            return this.simulationDescriptorReferenceField;
        }
        set {
            this.simulationDescriptorReferenceField = value;
            this.RaisePropertyChanged("SimulationDescriptorReference");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SimulationTag {
        get {
            return this.simulationTagField;
        }
        set {
            this.simulationTagField = value;
            this.RaisePropertyChanged("SimulationTag");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Constrained {
        get {
            return this.constrainedField;
        }
        set {
            this.constrainedField = value;
            this.RaisePropertyChanged("Constrained");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ApplyOnEmpire {
        get {
            return this.applyOnEmpireField;
        }
        set {
            this.applyOnEmpireField = value;
            this.RaisePropertyChanged("ApplyOnEmpire");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferencePlay))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferenceOfEncounterPlayDefinition : Droppable {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
            this.RaisePropertyChanged("Name");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableReferencePlay : DroppableReferenceOfEncounterPlayDefinition {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DroppableFaction : Droppable {
    
    private string factionNameField;
    
    private string titleField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FactionName {
        get {
            return this.factionNameField;
        }
        set {
            this.factionNameField = value;
            this.RaisePropertyChanged("FactionName");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
            this.RaisePropertyChanged("Title");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class Droplist : DatatableElement {
    
    private Droppable[] itemsField;
    
    private int picksField;
    
    private DroplistSelector selectorField;
    
    private bool retryOnFailureField;
    
    private string categoryField;
    
    private string fallbackField;
    
    public Droplist() {
        this.picksField = 1;
        this.selectorField = DroplistSelector.Weighted;
        this.retryOnFailureField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Blueprint", typeof(DroppableBlueprint), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Faction", typeof(DroppableFaction), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Fleet", typeof(DroppableFleet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Hero", typeof(DroppableReferenceHero), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Integer", typeof(DroppableInteger), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Law", typeof(DroppableReferenceLaw), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("List", typeof(DroppableReferenceList), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Module", typeof(DroppableModule), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Play", typeof(DroppableReferencePlay), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Resource", typeof(DroppableResource), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("String", typeof(DroppableString), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Technology", typeof(DroppableReferenceTechnology), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Unlock", typeof(DroppableReferenceUnlock), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Droppable[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
            this.RaisePropertyChanged("Items");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int Picks {
        get {
            return this.picksField;
        }
        set {
            this.picksField = value;
            this.RaisePropertyChanged("Picks");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(DroplistSelector.Weighted)]
    public DroplistSelector Selector {
        get {
            return this.selectorField;
        }
        set {
            this.selectorField = value;
            this.RaisePropertyChanged("Selector");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool RetryOnFailure {
        get {
            return this.retryOnFailureField;
        }
        set {
            this.retryOnFailureField = value;
            this.RaisePropertyChanged("RetryOnFailure");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Category {
        get {
            return this.categoryField;
        }
        set {
            this.categoryField = value;
            this.RaisePropertyChanged("Category");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Fallback {
        get {
            return this.fallbackField;
        }
        set {
            this.fallbackField = value;
            this.RaisePropertyChanged("Fallback");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum DroplistSelector {
    
    /// <remarks/>
    Weighted,
    
    /// <remarks/>
    Default,
    
    /// <remarks/>
    TurnProgression,
}
