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
namespace ES2.XSD.AnomalyReductionDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConstructionCost : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool instantField;
        
        private bool instantOnCompletionField;
        
        private string resourceNameField;
        
        private float valueField;
        
        public ConstructionCost() {
            this.instantField = false;
            this.instantOnCompletionField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Instant {
            get {
                return this.instantField;
            }
            set {
                this.instantField = value;
                this.RaisePropertyChanged("Instant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InstantOnCompletion {
            get {
                return this.instantOnCompletionField;
            }
            set {
                this.instantOnCompletionField = value;
                this.RaisePropertyChanged("InstantOnCompletion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResourceName {
            get {
                return this.resourceNameField;
            }
            set {
                this.resourceNameField = value;
                this.RaisePropertyChanged("ResourceName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public float Value {
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
    public partial class CustomConstructionCost : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool instantField;
        
        private bool instantOnCompletionField;
        
        private string resourceNameField;
        
        private string valueField;
        
        public CustomConstructionCost() {
            this.instantField = false;
            this.instantOnCompletionField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Instant {
            get {
                return this.instantField;
            }
            set {
                this.instantField = value;
                this.RaisePropertyChanged("Instant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InstantOnCompletion {
            get {
                return this.instantOnCompletionField;
            }
            set {
                this.instantOnCompletionField = value;
                this.RaisePropertyChanged("InstantOnCompletion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResourceName {
            get {
                return this.resourceNameField;
            }
            set {
                this.resourceNameField = value;
                this.RaisePropertyChanged("ResourceName");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnlockDatatableElement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstructibleElement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnomalyReductionDefinition))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstructibleElement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnomalyReductionDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnlockDatatableElement : DatatableElement {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnomalyReductionDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConstructibleElement : UnlockDatatableElement {
        
        private AIGain[] aIGainField;
        
        private SupervisorGain[] supervisorGainField;
        
        private float buyoutCostModifierField;
        
        private Tags tagsField;
        
        private SimulationDescriptorReference[] inProgressSimulationDescriptorReferenceField;
        
        private SimulationDescriptorReference[] queuedSimulationDescriptorReferenceField;
        
        private XmlNamedReference constructionQueueEntityActionReferenceField;
        
        private CostReductionReference[] costReductionReferenceField;
        
        private object[] itemsField;
        
        private Prerequisite[] items1Field;
        
        private MetaPrerequisite[] metaPrerequisiteField;
        
        private SimulationDescriptorReference[] simulationDescriptorReferenceField;
        
        private XmlNamedReference[] populationEventField;
        
        private bool stackableField;
        
        private string categoryField;
        
        private string subCategoryField;
        
        private string scoreProviderField;
        
        private bool hiddenField;
        
        private bool consumeResourceSurplusField;
        
        public ConstructibleElement() {
            this.buyoutCostModifierField = ((float)(0F));
            this.stackableField = false;
            this.hiddenField = false;
            this.consumeResourceSurplusField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AIGain", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AIGain[] AIGain {
            get {
                return this.aIGainField;
            }
            set {
                this.aIGainField = value;
                this.RaisePropertyChanged("AIGain");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupervisorGain", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SupervisorGain[] SupervisorGain {
            get {
                return this.supervisorGainField;
            }
            set {
                this.supervisorGainField = value;
                this.RaisePropertyChanged("SupervisorGain");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float BuyoutCostModifier {
            get {
                return this.buyoutCostModifierField;
            }
            set {
                this.buyoutCostModifierField = value;
                this.RaisePropertyChanged("BuyoutCostModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tags Tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
                this.RaisePropertyChanged("Tags");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InProgressSimulationDescriptorReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] InProgressSimulationDescriptorReference {
            get {
                return this.inProgressSimulationDescriptorReferenceField;
            }
            set {
                this.inProgressSimulationDescriptorReferenceField = value;
                this.RaisePropertyChanged("InProgressSimulationDescriptorReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueuedSimulationDescriptorReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationDescriptorReference[] QueuedSimulationDescriptorReference {
            get {
                return this.queuedSimulationDescriptorReferenceField;
            }
            set {
                this.queuedSimulationDescriptorReferenceField = value;
                this.RaisePropertyChanged("QueuedSimulationDescriptorReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference ConstructionQueueEntityActionReference {
            get {
                return this.constructionQueueEntityActionReferenceField;
            }
            set {
                this.constructionQueueEntityActionReferenceField = value;
                this.RaisePropertyChanged("ConstructionQueueEntityActionReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CostReductionReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CostReductionReference[] CostReductionReference {
            get {
                return this.costReductionReferenceField;
            }
            set {
                this.costReductionReferenceField = value;
                this.RaisePropertyChanged("CostReductionReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(ConstructionCost), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CustomCost", typeof(CustomConstructionCost), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("InfiniteCost", typeof(InfiniteCost), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DownloadableContentPrerequisite", typeof(DownloadableContentPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SupportPrerequisite", typeof(SupportPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElementAttribute("MetaPrerequisite", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MetaPrerequisite[] MetaPrerequisite {
            get {
                return this.metaPrerequisiteField;
            }
            set {
                this.metaPrerequisiteField = value;
                this.RaisePropertyChanged("MetaPrerequisite");
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
        [System.Xml.Serialization.XmlElementAttribute("PopulationEvent", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference[] PopulationEvent {
            get {
                return this.populationEventField;
            }
            set {
                this.populationEventField = value;
                this.RaisePropertyChanged("PopulationEvent");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Stackable {
            get {
                return this.stackableField;
            }
            set {
                this.stackableField = value;
                this.RaisePropertyChanged("Stackable");
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ScoreProvider {
            get {
                return this.scoreProviderField;
            }
            set {
                this.scoreProviderField = value;
                this.RaisePropertyChanged("ScoreProvider");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
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
        public bool ConsumeResourceSurplus {
            get {
                return this.consumeResourceSurplusField;
            }
            set {
                this.consumeResourceSurplusField = value;
                this.RaisePropertyChanged("ConsumeResourceSurplus");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AIGain : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] tagField;
        
        private string ressourceNameField;
        
        private bool invertedField;
        
        public AIGain() {
            this.invertedField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tag", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("Tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RessourceName {
            get {
                return this.ressourceNameField;
            }
            set {
                this.ressourceNameField = value;
                this.RaisePropertyChanged("RessourceName");
            }
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
    public partial class SupervisorGain : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Tags tagsField;
        
        private string nameField;
        
        private float weightField;
        
        public SupervisorGain() {
            this.weightField = ((float)(1F));
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tags Tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
                this.RaisePropertyChanged("Tags");
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
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
        public float Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
                this.RaisePropertyChanged("Weight");
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
    public partial class Tags : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    public partial class CostReductionReference : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    public partial class InfiniteCost : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string resourceNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResourceName {
            get {
                return this.resourceNameField;
            }
            set {
                this.resourceNameField = value;
                this.RaisePropertyChanged("ResourceName");
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
    public partial class DownloadableContentPrerequisite : Prerequisite {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PathPrerequisite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterpreterPrerequisite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PathValidityPrerequisite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyPrerequisite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupportPrerequisite))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DownloadableContentPrerequisite))]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MetaPrerequisite : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Prerequisite[] itemsField;
        
        private PrerequisiteOperator operatorField;
        
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
        public PrerequisiteOperator Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
                this.RaisePropertyChanged("Operator");
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
    public enum PrerequisiteOperator {
        
        /// <remarks/>
        Or,
        
        /// <remarks/>
        And,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class AnomalyReductionDefinition : ConstructibleElement {
        
        private XmlNamedReference baseAnomalyField;
        
        private XmlNamedReference resultAnomalyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference BaseAnomaly {
            get {
                return this.baseAnomalyField;
            }
            set {
                this.baseAnomalyField = value;
                this.RaisePropertyChanged("BaseAnomaly");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference ResultAnomaly {
            get {
                return this.resultAnomalyField;
            }
            set {
                this.resultAnomalyField = value;
                this.RaisePropertyChanged("ResultAnomaly");
            }
        }
    }
}