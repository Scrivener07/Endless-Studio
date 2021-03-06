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
namespace ES2.XSD.Amplitude.Unity.Simulation.SimulationDescriptor_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SingleSimulationModifierDescriptor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySimulationModifierDescriptor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountSimulationModifierDescriptor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SimulationModifierDescriptor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool searchValueFromPathField;
        
        private ModifierOperation operationField;
        
        private float priorityField;
        
        private string tooltipOverrideField;
        
        private bool tooltipHiddenField;
        
        private bool tooltipHiddenIfPathInvalidField;
        
        private bool valueMustBePositiveField;
        
        private string pathField;
        
        private string targetPropertyField;
        
        public SimulationModifierDescriptor() {
            this.searchValueFromPathField = false;
            this.priorityField = ((float)(0F));
            this.tooltipOverrideField = "";
            this.tooltipHiddenField = false;
            this.tooltipHiddenIfPathInvalidField = false;
            this.valueMustBePositiveField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SearchValueFromPath {
            get {
                return this.searchValueFromPathField;
            }
            set {
                this.searchValueFromPathField = value;
                this.RaisePropertyChanged("SearchValueFromPath");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ModifierOperation Operation {
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
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float Priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
                this.RaisePropertyChanged("Priority");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TooltipOverride {
            get {
                return this.tooltipOverrideField;
            }
            set {
                this.tooltipOverrideField = value;
                this.RaisePropertyChanged("TooltipOverride");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TooltipHidden {
            get {
                return this.tooltipHiddenField;
            }
            set {
                this.tooltipHiddenField = value;
                this.RaisePropertyChanged("TooltipHidden");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TooltipHiddenIfPathInvalid {
            get {
                return this.tooltipHiddenIfPathInvalidField;
            }
            set {
                this.tooltipHiddenIfPathInvalidField = value;
                this.RaisePropertyChanged("TooltipHiddenIfPathInvalid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ValueMustBePositive {
            get {
                return this.valueMustBePositiveField;
            }
            set {
                this.valueMustBePositiveField = value;
                this.RaisePropertyChanged("ValueMustBePositive");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("Path");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetProperty {
            get {
                return this.targetPropertyField;
            }
            set {
                this.targetPropertyField = value;
                this.RaisePropertyChanged("TargetProperty");
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
    public enum ModifierOperation {
        
        /// <remarks/>
        Force,
        
        /// <remarks/>
        Addition,
        
        /// <remarks/>
        Subtraction,
        
        /// <remarks/>
        Multiplication,
        
        /// <remarks/>
        Division,
        
        /// <remarks/>
        Power,
        
        /// <remarks/>
        Percent,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SingleSimulationModifierDescriptor : SimulationModifierDescriptor {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BinarySimulationModifierDescriptor : SimulationModifierDescriptor {
        
        private ModifierOperation binaryOperationField;
        
        private string leftField;
        
        private string rightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ModifierOperation BinaryOperation {
            get {
                return this.binaryOperationField;
            }
            set {
                this.binaryOperationField = value;
                this.RaisePropertyChanged("BinaryOperation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Left {
            get {
                return this.leftField;
            }
            set {
                this.leftField = value;
                this.RaisePropertyChanged("Left");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Right {
            get {
                return this.rightField;
            }
            set {
                this.rightField = value;
                this.RaisePropertyChanged("Right");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CountSimulationModifierDescriptor : SimulationModifierDescriptor {
        
        private string multiplierField;
        
        private string countPathField;
        
        public CountSimulationModifierDescriptor() {
            this.multiplierField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string Multiplier {
            get {
                return this.multiplierField;
            }
            set {
                this.multiplierField = value;
                this.RaisePropertyChanged("Multiplier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountPath {
            get {
                return this.countPathField;
            }
            set {
                this.countPathField = value;
                this.RaisePropertyChanged("CountPath");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimulationPropertyDescriptor_Proportional))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SimulationPropertyDescriptor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private float baseValueField;
        
        private SimulationPropertyComposition compositionField;
        
        private SimulationPropertyRoundingFunction roundingFunctionField;
        
        private bool isSealedField;
        
        private bool isSerializableField;
        
        private string nameField;
        
        private string maxValueField;
        
        private string minValueField;
        
        public SimulationPropertyDescriptor() {
            this.baseValueField = ((float)(0F));
            this.compositionField = SimulationPropertyComposition.None;
            this.roundingFunctionField = SimulationPropertyRoundingFunction.None;
            this.isSealedField = false;
            this.isSerializableField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float BaseValue {
            get {
                return this.baseValueField;
            }
            set {
                this.baseValueField = value;
                this.RaisePropertyChanged("BaseValue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SimulationPropertyComposition.None)]
        public SimulationPropertyComposition Composition {
            get {
                return this.compositionField;
            }
            set {
                this.compositionField = value;
                this.RaisePropertyChanged("Composition");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SimulationPropertyRoundingFunction.None)]
        public SimulationPropertyRoundingFunction RoundingFunction {
            get {
                return this.roundingFunctionField;
            }
            set {
                this.roundingFunctionField = value;
                this.RaisePropertyChanged("RoundingFunction");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsSealed {
            get {
                return this.isSealedField;
            }
            set {
                this.isSealedField = value;
                this.RaisePropertyChanged("IsSealed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsSerializable {
            get {
                return this.isSerializableField;
            }
            set {
                this.isSerializableField = value;
                this.RaisePropertyChanged("IsSerializable");
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
        public string MaxValue {
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
        public string MinValue {
            get {
                return this.minValueField;
            }
            set {
                this.minValueField = value;
                this.RaisePropertyChanged("MinValue");
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
    public enum SimulationPropertyComposition {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Maximum,
        
        /// <remarks/>
        Minimum,
        
        /// <remarks/>
        Sum,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum SimulationPropertyRoundingFunction {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Ceil,
        
        /// <remarks/>
        Floor,
        
        /// <remarks/>
        Round,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SimulationPropertyDescriptor_Proportional : SimulationPropertyDescriptor {
        
        private string maximumField;
        
        private string minimumField;
        
        private float startingRatioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Maximum {
            get {
                return this.maximumField;
            }
            set {
                this.maximumField = value;
                this.RaisePropertyChanged("Maximum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Minimum {
            get {
                return this.minimumField;
            }
            set {
                this.minimumField = value;
                this.RaisePropertyChanged("Minimum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float StartingRatio {
            get {
                return this.startingRatioField;
            }
            set {
                this.startingRatioField = value;
                this.RaisePropertyChanged("StartingRatio");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class SimulationDescriptor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SimulationPropertyDescriptor[] itemsField;
        
        private SimulationModifierDescriptor[] items1Field;
        
        private bool isSerializableField;
        
        private string nameField;
        
        private string typeField;
        
        public SimulationDescriptor() {
            this.isSerializableField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property", typeof(SimulationPropertyDescriptor), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ProportionalProperty", typeof(SimulationPropertyDescriptor_Proportional), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationPropertyDescriptor[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryModifier", typeof(BinarySimulationModifierDescriptor), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CountModifier", typeof(CountSimulationModifierDescriptor), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Modifier", typeof(SingleSimulationModifierDescriptor), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SimulationModifierDescriptor[] Items1 {
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
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsSerializable {
            get {
                return this.isSerializableField;
            }
            set {
                this.isSerializableField = value;
                this.RaisePropertyChanged("IsSerializable");
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
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
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
