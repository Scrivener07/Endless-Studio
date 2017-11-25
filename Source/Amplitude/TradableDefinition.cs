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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableHeroDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableShipDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableResourceDefinition))]
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableHeroDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableShipDefinition))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TradableResourceDefinition))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class TradableDefinition : DatatableElement {
    
    private string basePriceField;
    
    private SimulationDescriptorReference[] simulationDescriptorReferenceField;
    
    private string categoryField;
    
    private string subCategoryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BasePrice {
        get {
            return this.basePriceField;
        }
        set {
            this.basePriceField = value;
            this.RaisePropertyChanged("BasePrice");
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
    public string SubCategory {
        get {
            return this.subCategoryField;
        }
        set {
            this.subCategoryField = value;
            this.RaisePropertyChanged("SubCategory");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class TradableResourceDefinition : TradableDefinition {
    
    private string startingQuantityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string StartingQuantity {
        get {
            return this.startingQuantityField;
        }
        set {
            this.startingQuantityField = value;
            this.RaisePropertyChanged("StartingQuantity");
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class TradableShipDefinition : TradableDefinition {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class TradableHeroDefinition : TradableDefinition {
}