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
namespace ES2.XSD.DiplomaticRelationState_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticRelationState))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticRelationStateTurnsTransition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiplomaticRelationStatePrerequisiteTransition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiplomaticRelationStateTransition : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string destinationStateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationState {
            get {
                return this.destinationStateField;
            }
            set {
                this.destinationStateField = value;
                this.RaisePropertyChanged("DestinationState");
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
    public partial class DiplomaticRelationStateTurnsTransition : DiplomaticRelationStateTransition {
        
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
    public partial class DiplomaticRelationStatePrerequisiteTransition : DiplomaticRelationStateTransition {
        
        private PathPrerequisite[] pathPrerequisiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PathPrerequisite[] PathPrerequisite {
            get {
                return this.pathPrerequisiteField;
            }
            set {
                this.pathPrerequisiteField = value;
                this.RaisePropertyChanged("PathPrerequisite");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterpreterPrerequisite))]
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
    public partial class InterpreterPrerequisite : Prerequisite {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiplomaticAbilityChange : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Prerequisite[] itemsField;
        
        private AbilityOperation operationField;
        
        private string diplomaticAbilityReferenceField;
        
        public DiplomaticAbilityChange() {
            this.operationField = AbilityOperation.Add;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AbilityOperation.Add)]
        public AbilityOperation Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
                this.RaisePropertyChanged("Operation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiplomaticAbilityReference {
            get {
                return this.diplomaticAbilityReferenceField;
            }
            set {
                this.diplomaticAbilityReferenceField = value;
                this.RaisePropertyChanged("DiplomaticAbilityReference");
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
    public enum AbilityOperation {
        
        /// <remarks/>
        Add,
        
        /// <remarks/>
        Remove,
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
    public partial class DiplomaticRelationState : DatatableElement {
        
        private XmlNamedReference diplomaticPressureEffectReferenceField;
        
        private DiplomaticAbilityChange[] diplomaticAbilityChangeField;
        
        private DiplomaticRelationStateTransition[] itemsField;
        
        private float stateEvaluationField;
        
        public DiplomaticRelationState() {
            this.stateEvaluationField = ((float)(0F));
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference DiplomaticPressureEffectReference {
            get {
                return this.diplomaticPressureEffectReferenceField;
            }
            set {
                this.diplomaticPressureEffectReferenceField = value;
                this.RaisePropertyChanged("DiplomaticPressureEffectReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiplomaticAbilityChange", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DiplomaticAbilityChange[] DiplomaticAbilityChange {
            get {
                return this.diplomaticAbilityChangeField;
            }
            set {
                this.diplomaticAbilityChangeField = value;
                this.RaisePropertyChanged("DiplomaticAbilityChange");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrerequisiteTransition", typeof(DiplomaticRelationStatePrerequisiteTransition), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TurnTransition", typeof(DiplomaticRelationStateTurnsTransition), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DiplomaticRelationStateTransition[] Items {
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
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float StateEvaluation {
            get {
                return this.stateEvaluationField;
            }
            set {
                this.stateEvaluationField = value;
                this.RaisePropertyChanged("StateEvaluation");
            }
        }
    }
}
