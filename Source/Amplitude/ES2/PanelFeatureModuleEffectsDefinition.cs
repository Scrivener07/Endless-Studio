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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PanelFeatureModuleEffectsDefinition))]
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
public partial class Item : object, System.ComponentModel.INotifyPropertyChanged {
    
    private string nameField;
    
    private string titleField;
    
    private string formatField;
    
    private float minValueField;
    
    private float maxValueField;
    
    private bool isPercentageField;
    
    private int decimalCountField;
    
    private string unitLocalizationKeyField;
    
    public Item() {
        this.minValueField = ((float)(-3.402823E+38F));
        this.maxValueField = ((float)(3.402823E+38F));
        this.isPercentageField = false;
        this.decimalCountField = 0;
        this.unitLocalizationKeyField = "";
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
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
            this.RaisePropertyChanged("Title");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Format {
        get {
            return this.formatField;
        }
        set {
            this.formatField = value;
            this.RaisePropertyChanged("Format");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(float), "-3.402823E+38")]
    public float MinValue {
        get {
            return this.minValueField;
        }
        set {
            this.minValueField = value;
            this.RaisePropertyChanged("MinValue");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(float), "3.402823E+38")]
    public float MaxValue {
        get {
            return this.maxValueField;
        }
        set {
            this.maxValueField = value;
            this.RaisePropertyChanged("MaxValue");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IsPercentage {
        get {
            return this.isPercentageField;
        }
        set {
            this.isPercentageField = value;
            this.RaisePropertyChanged("IsPercentage");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int DecimalCount {
        get {
            return this.decimalCountField;
        }
        set {
            this.decimalCountField = value;
            this.RaisePropertyChanged("DecimalCount");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string UnitLocalizationKey {
        get {
            return this.unitLocalizationKeyField;
        }
        set {
            this.unitLocalizationKeyField = value;
            this.RaisePropertyChanged("UnitLocalizationKey");
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
public partial class Category : object, System.ComponentModel.INotifyPropertyChanged {
    
    private Item[] itemField;
    
    private string[] specialField;
    
    private string nameField;
    
    private string titleField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Item[] Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
            this.RaisePropertyChanged("Item");
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Special", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string[] Special {
        get {
            return this.specialField;
        }
        set {
            this.specialField = value;
            this.RaisePropertyChanged("Special");
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
public partial class PanelFeatureModuleEffectsDefinition : DatatableElement {
    
    private Category[] categoryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Category", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Category[] Category {
        get {
            return this.categoryField;
        }
        set {
            this.categoryField = value;
            this.RaisePropertyChanged("Category");
        }
    }
}
