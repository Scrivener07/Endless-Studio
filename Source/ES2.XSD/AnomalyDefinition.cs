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
namespace ES2.XSD.AnomalyDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnomalyDefinition))]
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
    public partial class PlanetFilterNot : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string valueField;
        
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DummyGeneratorInfo))]
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
    public partial class DummyGeneratorInfo : ValueType {
        
        private PlanetFilterNot[] planetFilterNotField;
        
        private bool excludeFromRandomPlacementField;
        
        public DummyGeneratorInfo() {
            this.excludeFromRandomPlacementField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlanetFilterNot", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PlanetFilterNot[] PlanetFilterNot {
            get {
                return this.planetFilterNotField;
            }
            set {
                this.planetFilterNotField = value;
                this.RaisePropertyChanged("PlanetFilterNot");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ExcludeFromRandomPlacement {
            get {
                return this.excludeFromRandomPlacementField;
            }
            set {
                this.excludeFromRandomPlacementField = value;
                this.RaisePropertyChanged("ExcludeFromRandomPlacement");
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class AnomalyDefinition : DatatableElement {
        
        private SimulationDescriptorReference[] simulationDescriptorReferenceField;
        
        private SimulationDescriptorReference[] encounterGlobalEffectDescriptorReferenceField;
        
        private XmlNamedReference[] encounterEntityReferenceField;
        
        private DummyGeneratorInfo[] generatorInfoField;
        
        private AnomalyQuality qualityField;
        
        private bool indestructibleField;
        
        public AnomalyDefinition() {
            this.indestructibleField = false;
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
        [System.Xml.Serialization.XmlElementAttribute("EncounterGlobalEffectDescriptorReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] EncounterGlobalEffectDescriptorReference {
            get {
                return this.encounterGlobalEffectDescriptorReferenceField;
            }
            set {
                this.encounterGlobalEffectDescriptorReferenceField = value;
                this.RaisePropertyChanged("EncounterGlobalEffectDescriptorReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncounterEntityReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference[] EncounterEntityReference {
            get {
                return this.encounterEntityReferenceField;
            }
            set {
                this.encounterEntityReferenceField = value;
                this.RaisePropertyChanged("EncounterEntityReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneratorInfo", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DummyGeneratorInfo[] GeneratorInfo {
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
        public AnomalyQuality Quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
                this.RaisePropertyChanged("Quality");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Indestructible {
            get {
                return this.indestructibleField;
            }
            set {
                this.indestructibleField = value;
                this.RaisePropertyChanged("Indestructible");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum AnomalyQuality {
        
        /// <remarks/>
        Negative,
        
        /// <remarks/>
        Mixed,
        
        /// <remarks/>
        Positive,
        
        /// <remarks/>
        Reduced,
        
        /// <remarks/>
        Moon,
    }
}