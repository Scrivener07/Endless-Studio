﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8762
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace ES2.XSD.Generator.Definitions.PlanetaryAnomalyDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GeneratorInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] planetFilterMustField;
        
        private string[] planetFilterAnyField;
        
        private string[] planetFilterNotField;
        
        private string[] planetTagsReplaceField;
        
        private bool excludeFromRandomPlacementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanetFilterMust", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PlanetFilterMust {
            get {
                return this.planetFilterMustField;
            }
            set {
                this.planetFilterMustField = value;
                this.RaisePropertyChanged("PlanetFilterMust");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanetFilterAny", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PlanetFilterAny {
            get {
                return this.planetFilterAnyField;
            }
            set {
                this.planetFilterAnyField = value;
                this.RaisePropertyChanged("PlanetFilterAny");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanetFilterNot", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PlanetFilterNot {
            get {
                return this.planetFilterNotField;
            }
            set {
                this.planetFilterNotField = value;
                this.RaisePropertyChanged("PlanetFilterNot");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanetTagsReplace", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PlanetTagsReplace {
            get {
                return this.planetTagsReplaceField;
            }
            set {
                this.planetTagsReplaceField = value;
                this.RaisePropertyChanged("PlanetTagsReplace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeFromRandomPlacement {
            get {
                return this.excludeFromRandomPlacementField;
            }
            set {
                this.excludeFromRandomPlacementField = value;
                this.RaisePropertyChanged("ExcludeFromRandomPlacement");
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
    public partial class AnomalyDefinition : object, System.ComponentModel.INotifyPropertyChanged {
        
        private GeneratorInfo generatorInfoField;
        
        private string nameField;
        
        private string qualityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GeneratorInfo GeneratorInfo {
            get {
                return this.generatorInfoField;
            }
            set {
                this.generatorInfoField = value;
                this.RaisePropertyChanged("GeneratorInfo");
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
        public string Quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
                this.RaisePropertyChanged("Quality");
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
}