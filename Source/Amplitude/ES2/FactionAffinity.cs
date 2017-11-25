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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FactionTrait))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FactionAffinity))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FactionAffinity))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FactionTrait : DatatableElement {
    
    private Command[] commandField;
    
    private XmlNamedReference[] outpostImprovementReferenceField;
    
    private XmlNamedReference[] colonyImprovementReferenceField;
    
    private XmlNamedReference[] subTraitField;
    
    private SimulationDescriptorReference[] simulationDescriptorReferenceField;
    
    private FactionTraitTooltipOverride factionTraitTooltipOverrideField;
    
    private string prerequisitesField;
    
    private int costField;
    
    private string familyField;
    
    private bool hiddenField;
    
    private bool customField;
    
    private bool hiddenOnFailPrerequisitesField;
    
    private bool validWithAtLeastOnePrerequisiteField;
    
    private float levelField;
    
    private string rootField;
    
    private bool ignoreForTraitsCountField;
    
    private string subCategoryField;
    
    private string traitCategoryField;
    
    private string traitSubCategoryField;
    
    public FactionTrait() {
        this.costField = 0;
        this.hiddenField = true;
        this.customField = false;
        this.hiddenOnFailPrerequisitesField = false;
        this.validWithAtLeastOnePrerequisiteField = false;
        this.levelField = ((float)(0F));
        this.ignoreForTraitsCountField = false;
        this.traitCategoryField = "";
        this.traitSubCategoryField = "";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Command", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Command[] Command {
        get {
            return this.commandField;
        }
        set {
            this.commandField = value;
            this.RaisePropertyChanged("Command");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OutpostImprovementReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference[] OutpostImprovementReference {
        get {
            return this.outpostImprovementReferenceField;
        }
        set {
            this.outpostImprovementReferenceField = value;
            this.RaisePropertyChanged("OutpostImprovementReference");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ColonyImprovementReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference[] ColonyImprovementReference {
        get {
            return this.colonyImprovementReferenceField;
        }
        set {
            this.colonyImprovementReferenceField = value;
            this.RaisePropertyChanged("ColonyImprovementReference");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubTrait", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference[] SubTrait {
        get {
            return this.subTraitField;
        }
        set {
            this.subTraitField = value;
            this.RaisePropertyChanged("SubTrait");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SimulationDescriptorReference[] SimulationDescriptorReference {
        get {
            return this.simulationDescriptorReferenceField;
        }
        set {
            this.simulationDescriptorReferenceField = value;
            this.RaisePropertyChanged("SimulationDescriptorReference");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public FactionTraitTooltipOverride FactionTraitTooltipOverride {
        get {
            return this.factionTraitTooltipOverrideField;
        }
        set {
            this.factionTraitTooltipOverrideField = value;
            this.RaisePropertyChanged("FactionTraitTooltipOverride");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Prerequisites {
        get {
            return this.prerequisitesField;
        }
        set {
            this.prerequisitesField = value;
            this.RaisePropertyChanged("Prerequisites");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int Cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
            this.RaisePropertyChanged("Cost");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Family {
        get {
            return this.familyField;
        }
        set {
            this.familyField = value;
            this.RaisePropertyChanged("Family");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Hidden {
        get {
            return this.hiddenField;
        }
        set {
            this.hiddenField = value;
            this.RaisePropertyChanged("Hidden");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Custom {
        get {
            return this.customField;
        }
        set {
            this.customField = value;
            this.RaisePropertyChanged("Custom");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool HiddenOnFailPrerequisites {
        get {
            return this.hiddenOnFailPrerequisitesField;
        }
        set {
            this.hiddenOnFailPrerequisitesField = value;
            this.RaisePropertyChanged("HiddenOnFailPrerequisites");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ValidWithAtLeastOnePrerequisite {
        get {
            return this.validWithAtLeastOnePrerequisiteField;
        }
        set {
            this.validWithAtLeastOnePrerequisiteField = value;
            this.RaisePropertyChanged("ValidWithAtLeastOnePrerequisite");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
    public float Level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
            this.RaisePropertyChanged("Level");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Root {
        get {
            return this.rootField;
        }
        set {
            this.rootField = value;
            this.RaisePropertyChanged("Root");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IgnoreForTraitsCount {
        get {
            return this.ignoreForTraitsCountField;
        }
        set {
            this.ignoreForTraitsCountField = value;
            this.RaisePropertyChanged("IgnoreForTraitsCount");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubCategory {
        get {
            return this.subCategoryField;
        }
        set {
            this.subCategoryField = value;
            this.RaisePropertyChanged("SubCategory");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string TraitCategory {
        get {
            return this.traitCategoryField;
        }
        set {
            this.traitCategoryField = value;
            this.RaisePropertyChanged("TraitCategory");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string TraitSubCategory {
        get {
            return this.traitSubCategoryField;
        }
        set {
            this.traitSubCategoryField = value;
            this.RaisePropertyChanged("TraitSubCategory");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Command : object, System.ComponentModel.INotifyPropertyChanged {
    
    private string nameField;
    
    private string argumentsField;
    
    private int priorityField;
    
    public Command() {
        this.priorityField = 0;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Arguments {
        get {
            return this.argumentsField;
        }
        set {
            this.argumentsField = value;
            this.RaisePropertyChanged("Arguments");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int Priority {
        get {
            return this.priorityField;
        }
        set {
            this.priorityField = value;
            this.RaisePropertyChanged("Priority");
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class XmlNamedReference : object, System.ComponentModel.INotifyPropertyChanged {
    
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SimulationDescriptorReference : ValueType {
    
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SimulationDescriptorReference))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ValueType : object, System.ComponentModel.INotifyPropertyChanged {
    
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    protected void RaisePropertyChanged(string propertyName) {
        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if ((propertyChanged != null)) {
            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FactionTraitTooltipOverride : object, System.ComponentModel.INotifyPropertyChanged {
    
    private OverrideType typeField;
    
    private string overrideNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public OverrideType Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
            this.RaisePropertyChanged("Type");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OverrideName {
        get {
            return this.overrideNameField;
        }
        set {
            this.overrideNameField = value;
            this.RaisePropertyChanged("OverrideName");
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
public enum OverrideType {
    
    /// <remarks/>
    Constructible,
    
    /// <remarks/>
    Technology,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class FactionAffinity : FactionTrait {
    
    private string defaultColonizerField;
    
    private string automatedShipField;
    
    private string unlockedAbstractShipDesignsField;
    
    private string startingFleetsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DefaultColonizer {
        get {
            return this.defaultColonizerField;
        }
        set {
            this.defaultColonizerField = value;
            this.RaisePropertyChanged("DefaultColonizer");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string AutomatedShip {
        get {
            return this.automatedShipField;
        }
        set {
            this.automatedShipField = value;
            this.RaisePropertyChanged("AutomatedShip");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UnlockedAbstractShipDesigns {
        get {
            return this.unlockedAbstractShipDesignsField;
        }
        set {
            this.unlockedAbstractShipDesignsField = value;
            this.RaisePropertyChanged("UnlockedAbstractShipDesigns");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string StartingFleets {
        get {
            return this.startingFleetsField;
        }
        set {
            this.startingFleetsField = value;
            this.RaisePropertyChanged("StartingFleets");
        }
    }
}
