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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PathValidityPrerequisite))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyPrerequisite))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SupportPrerequisite))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyPrerequisite))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PathValidityPrerequisite : Prerequisite {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TechnologyPrerequisite : PathValidityPrerequisite {
    
    private bool unlockHiddenField;
    
    public TechnologyPrerequisite() {
        this.unlockHiddenField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UnlockHidden {
        get {
            return this.unlockHiddenField;
        }
        set {
            this.unlockHiddenField = value;
            this.RaisePropertyChanged("UnlockHidden");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SupportPrerequisite : Prerequisite {
    
    private string politicsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Politics {
        get {
            return this.politicsField;
        }
        set {
            this.politicsField = value;
            this.RaisePropertyChanged("Politics");
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeVisibilityConditionsDefinition))]
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
public partial class NodeVisibilityConditionsDefinition : DatatableElement {
    
    private Prerequisite[] itemsField;
    
    private bool startInvisibleField;
    
    private bool ignoreForGalaxyDiscoveryField;
    
    public NodeVisibilityConditionsDefinition() {
        this.startInvisibleField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("SupportPrerequisite", typeof(SupportPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool StartInvisible {
        get {
            return this.startInvisibleField;
        }
        set {
            this.startInvisibleField = value;
            this.RaisePropertyChanged("StartInvisible");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IgnoreForGalaxyDiscovery {
        get {
            return this.ignoreForGalaxyDiscoveryField;
        }
        set {
            this.ignoreForGalaxyDiscoveryField = value;
            this.RaisePropertyChanged("IgnoreForGalaxyDiscovery");
        }
    }
}
