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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonalityPrerequisite))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PathPrerequisite))]
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
public partial class PersonalityPrerequisite : Prerequisite {
    
    private string personalityNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PersonalityName {
        get {
            return this.personalityNameField;
        }
        set {
            this.personalityNameField = value;
            this.RaisePropertyChanged("PersonalityName");
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonalityDefinition))]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class PersonalityDefinition : DatatableElement {
    
    private Prerequisite[] itemsField;
    
    private Prerequisite[] items1Field;
    
    private float weightField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RestrictionPathPrerequisites", typeof(PathPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("RestrictionPersonalityPrerequisites", typeof(PersonalityPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    [System.Xml.Serialization.XmlElementAttribute("ConditionPathPrerequisites", typeof(PathPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("ConditionPersonalityPrerequisites", typeof(PersonalityPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Prerequisite[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
            this.RaisePropertyChanged("Items1");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float Weight {
        get {
            return this.weightField;
        }
        set {
            this.weightField = value;
            this.RaisePropertyChanged("Weight");
        }
    }
}
