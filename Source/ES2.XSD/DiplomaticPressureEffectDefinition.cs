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
namespace ES2.XSD.DiplomaticPressureEffectDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_Turns))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_Systems))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_DiplomaticAbility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_DiplomaticRelationState))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_Turns))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_Systems))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_DiplomaticAbility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_DiplomaticRelationState))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DiplomaticPressureEffectDefinition : DatatableElement {
        
        private SimulationDescriptorReference[] simulationDescriptorReferenceOnInitiatorField;
        
        private SimulationDescriptorReference[] simulationDescriptorReferenceOnTargetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReferenceOnInitiator", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] SimulationDescriptorReferenceOnInitiator {
            get {
                return this.simulationDescriptorReferenceOnInitiatorField;
            }
            set {
                this.simulationDescriptorReferenceOnInitiatorField = value;
                this.RaisePropertyChanged("SimulationDescriptorReferenceOnInitiator");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReferenceOnTarget", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] SimulationDescriptorReferenceOnTarget {
            get {
                return this.simulationDescriptorReferenceOnTargetField;
            }
            set {
                this.simulationDescriptorReferenceOnTargetField = value;
                this.RaisePropertyChanged("SimulationDescriptorReferenceOnTarget");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DiplomaticPressureEffectDefinition_DiplomaticRelationState : DiplomaticPressureEffectDefinition {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DiplomaticPressureEffectDefinition_DiplomaticAbility : DiplomaticPressureEffectDefinition {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticPressureEffectDefinition_Systems))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DiplomaticPressureEffectDefinition_Turns : DiplomaticPressureEffectDefinition {
        
        private int durationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
                this.RaisePropertyChanged("Duration");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DiplomaticPressureEffectDefinition_Systems : DiplomaticPressureEffectDefinition_Turns {
        
        private SimulationDescriptorReference[] systemDescriptorField;
        
        private SimulationDescriptorReference[] fleetDescriptorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemDescriptor", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] SystemDescriptor {
            get {
                return this.systemDescriptorField;
            }
            set {
                this.systemDescriptorField = value;
                this.RaisePropertyChanged("SystemDescriptor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FleetDescriptor", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] FleetDescriptor {
            get {
                return this.fleetDescriptorField;
            }
            set {
                this.fleetDescriptorField = value;
                this.RaisePropertyChanged("FleetDescriptor");
            }
        }
    }
}
