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
namespace ES2.XSD.GovernmentDefinition_SCHEMA {
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentDefinition))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_ClearLaws))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_ClearSenators))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_CreateOppositeSenator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_ForceElections))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_Notify))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_TriggerPoliticalPopulationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAction_TriggerTemporaryEffect))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    public partial class GovernmentAction_ClearLaws : GovernmentAction {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction_ClearSenators : GovernmentAction {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction_CreateOppositeSenator : GovernmentAction {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction_ForceElections : GovernmentAction {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction_Notify : GovernmentAction {
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("Class");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GovernmentAction_TriggerPoliticalPopulationEvent : GovernmentAction {
        
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
    public partial class GovernmentAction_TriggerTemporaryEffect : GovernmentAction {
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class GovernmentDefinition : DatatableElement {
        
        private Tags tagsField;
        
        private string durationFormulaField;
        
        private SimulationDescriptorReference[] simulationDescriptorReferenceField;
        
        private XmlNamedReference representativesElectionProcessReferenceField;
        
        private XmlNamedReference senateElectionProcessReferenceField;
        
        private XmlNamedReference surveyElectionProcessReferenceField;
        
        private float buyoutCostModifierField;
        
        private object[] itemsField;
        
        private XmlNamedReference nextGovernmentReferenceField;
        
        private XmlNamedReference anarchyGovernmentReferenceField;
        
        private XmlNamedReference[] populationEventField;
        
        private GovernmentAction[] onStartField;
        
        private GovernmentAction[] onEndField;
        
        private bool fixedField;
        
        private bool hiddenField;
        
        private int initialRepresentativeCountField;
        
        private int initialGovernmentCostField;
        
        private float requiredHappinessField;
        
        private int changeGovernmentCooldownField;
        
        private bool cancelNextForcedElectionField;
        
        public GovernmentDefinition() {
            this.durationFormulaField = "";
            this.buyoutCostModifierField = ((float)(0F));
            this.fixedField = false;
            this.hiddenField = false;
            this.initialRepresentativeCountField = 0;
            this.initialGovernmentCostField = 0;
            this.changeGovernmentCooldownField = 0;
            this.cancelNextForcedElectionField = false;
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DurationFormula {
            get {
                return this.durationFormulaField;
            }
            set {
                this.durationFormulaField = value;
                this.RaisePropertyChanged("DurationFormula");
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference RepresentativesElectionProcessReference {
            get {
                return this.representativesElectionProcessReferenceField;
            }
            set {
                this.representativesElectionProcessReferenceField = value;
                this.RaisePropertyChanged("RepresentativesElectionProcessReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference SenateElectionProcessReference {
            get {
                return this.senateElectionProcessReferenceField;
            }
            set {
                this.senateElectionProcessReferenceField = value;
                this.RaisePropertyChanged("SenateElectionProcessReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference SurveyElectionProcessReference {
            get {
                return this.surveyElectionProcessReferenceField;
            }
            set {
                this.surveyElectionProcessReferenceField = value;
                this.RaisePropertyChanged("SurveyElectionProcessReference");
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
        [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(ConstructionCost), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CustomCost", typeof(CustomConstructionCost), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference NextGovernmentReference {
            get {
                return this.nextGovernmentReferenceField;
            }
            set {
                this.nextGovernmentReferenceField = value;
                this.RaisePropertyChanged("NextGovernmentReference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlNamedReference AnarchyGovernmentReference {
            get {
                return this.anarchyGovernmentReferenceField;
            }
            set {
                this.anarchyGovernmentReferenceField = value;
                this.RaisePropertyChanged("AnarchyGovernmentReference");
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
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ClearLaws", typeof(GovernmentAction_ClearLaws), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ClearSenators", typeof(GovernmentAction_ClearSenators), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_CreateOppositeSenator", typeof(GovernmentAction_CreateOppositeSenator), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ForceElection", typeof(GovernmentAction_ForceElections), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_Notify", typeof(GovernmentAction_Notify), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_TriggerPoliticalPopulationEvent", typeof(GovernmentAction_TriggerPoliticalPopulationEvent), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_TriggerTemporaryEffect", typeof(GovernmentAction_TriggerTemporaryEffect), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GovernmentAction[] OnStart {
            get {
                return this.onStartField;
            }
            set {
                this.onStartField = value;
                this.RaisePropertyChanged("OnStart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ClearLaws", typeof(GovernmentAction_ClearLaws), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ClearSenators", typeof(GovernmentAction_ClearSenators), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_CreateOppositeSenator", typeof(GovernmentAction_CreateOppositeSenator), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_ForceElection", typeof(GovernmentAction_ForceElections), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_Notify", typeof(GovernmentAction_Notify), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_TriggerPoliticalPopulationEvent", typeof(GovernmentAction_TriggerPoliticalPopulationEvent), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Action_TriggerTemporaryEffect", typeof(GovernmentAction_TriggerTemporaryEffect), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GovernmentAction[] OnEnd {
            get {
                return this.onEndField;
            }
            set {
                this.onEndField = value;
                this.RaisePropertyChanged("OnEnd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Fixed {
            get {
                return this.fixedField;
            }
            set {
                this.fixedField = value;
                this.RaisePropertyChanged("Fixed");
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
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int InitialRepresentativeCount {
            get {
                return this.initialRepresentativeCountField;
            }
            set {
                this.initialRepresentativeCountField = value;
                this.RaisePropertyChanged("InitialRepresentativeCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int InitialGovernmentCost {
            get {
                return this.initialGovernmentCostField;
            }
            set {
                this.initialGovernmentCostField = value;
                this.RaisePropertyChanged("InitialGovernmentCost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float RequiredHappiness {
            get {
                return this.requiredHappinessField;
            }
            set {
                this.requiredHappinessField = value;
                this.RaisePropertyChanged("RequiredHappiness");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int ChangeGovernmentCooldown {
            get {
                return this.changeGovernmentCooldownField;
            }
            set {
                this.changeGovernmentCooldownField = value;
                this.RaisePropertyChanged("ChangeGovernmentCooldown");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CancelNextForcedElection {
            get {
                return this.cancelNextForcedElectionField;
            }
            set {
                this.cancelNextForcedElectionField = value;
                this.RaisePropertyChanged("CancelNextForcedElection");
            }
        }
    }
}
