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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PathPrerequisite))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InterpreterPrerequisite))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Prerequisite : object, System.ComponentModel.INotifyPropertyChanged {
    
    private bool invertedField;
    
    private string flagsField;
    
    private string valueField;
    
    public Prerequisite() {
        this.invertedField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Inverted {
        get {
            return this.invertedField;
        }
        set {
            this.invertedField = value;
            this.RaisePropertyChanged("Inverted");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Flags {
        get {
            return this.flagsField;
        }
        set {
            this.flagsField = value;
            this.RaisePropertyChanged("Flags");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
            this.RaisePropertyChanged("Value");
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
public partial class PathPrerequisite : Prerequisite {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InterpreterPrerequisite : Prerequisite {
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PoliticsDefinition))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LawDefinitionReference))]
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
public partial class LawDefinitionReference : ValueType {
    
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PoliticsPopulationModifier : object, System.ComponentModel.INotifyPropertyChanged {
    
    private SimulationDescriptorReference[] mainPoliticsDescriptorReferenceField;
    
    private string trendPropertyNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MainPoliticsDescriptorReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SimulationDescriptorReference[] MainPoliticsDescriptorReference {
        get {
            return this.mainPoliticsDescriptorReferenceField;
        }
        set {
            this.mainPoliticsDescriptorReferenceField = value;
            this.RaisePropertyChanged("MainPoliticsDescriptorReference");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TrendPropertyName {
        get {
            return this.trendPropertyNameField;
        }
        set {
            this.trendPropertyNameField = value;
            this.RaisePropertyChanged("TrendPropertyName");
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
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class PoliticsDefinition : DatatableElement {
    
    private XmlNamedReference opposedPoliticsField;
    
    private XmlNamedReference leftPoliticsField;
    
    private XmlNamedReference rightPoliticsField;
    
    private PoliticsPopulationModifier populationModifierField;
    
    private Prerequisite[] itemsField;
    
    private LawDefinitionReference[] lawDefinitionReferenceField;
    
    private SimulationDescriptorReference[] simulationDescriptorReferenceField;
    
    private bool isNeutralField;
    
    public PoliticsDefinition() {
        this.isNeutralField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference OpposedPolitics {
        get {
            return this.opposedPoliticsField;
        }
        set {
            this.opposedPoliticsField = value;
            this.RaisePropertyChanged("OpposedPolitics");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference LeftPolitics {
        get {
            return this.leftPoliticsField;
        }
        set {
            this.leftPoliticsField = value;
            this.RaisePropertyChanged("LeftPolitics");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public XmlNamedReference RightPolitics {
        get {
            return this.rightPoliticsField;
        }
        set {
            this.rightPoliticsField = value;
            this.RaisePropertyChanged("RightPolitics");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public PoliticsPopulationModifier PopulationModifier {
        get {
            return this.populationModifierField;
        }
        set {
            this.populationModifierField = value;
            this.RaisePropertyChanged("PopulationModifier");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Prerequisite[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
            this.RaisePropertyChanged("Items");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LawDefinitionReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public LawDefinitionReference[] LawDefinitionReference {
        get {
            return this.lawDefinitionReferenceField;
        }
        set {
            this.lawDefinitionReferenceField = value;
            this.RaisePropertyChanged("LawDefinitionReference");
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IsNeutral {
        get {
            return this.isNeutralField;
        }
        set {
            this.isNeutralField = value;
            this.RaisePropertyChanged("IsNeutral");
        }
    }
}
