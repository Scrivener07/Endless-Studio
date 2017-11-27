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
namespace ES2.XSD.EncounterFlotillaMatchDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EncounterFlotillaMatchTargetingRangeDefinition : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int phaseIndexField;
        
        private string rangeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PhaseIndex {
            get {
                return this.phaseIndexField;
            }
            set {
                this.phaseIndexField = value;
                this.RaisePropertyChanged("PhaseIndex");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RangeName {
            get {
                return this.rangeNameField;
            }
            set {
                this.rangeNameField = value;
                this.RaisePropertyChanged("RangeName");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EncounterFlotillaTrajectoryDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EncounterFlotillaMatchDefinition))]
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
    public partial class EncounterFlotillaTrajectoryDefinition : DatatableElement {
        
        private BezierPathDetailedInterpolation bezierPathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BezierPathDetailedInterpolation BezierPath {
            get {
                return this.bezierPathField;
            }
            set {
                this.bezierPathField = value;
                this.RaisePropertyChanged("BezierPath");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BezierPathDetailedInterpolation : BezierPathDetailed {
        
        private SerializableVector3[] handlesField;
        
        private float refinedControlPointsTangentScaleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Handles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerializableVector3[] Handles {
            get {
                return this.handlesField;
            }
            set {
                this.handlesField = value;
                this.RaisePropertyChanged("Handles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float RefinedControlPointsTangentScale {
            get {
                return this.refinedControlPointsTangentScaleField;
            }
            set {
                this.refinedControlPointsTangentScaleField = value;
                this.RaisePropertyChanged("RefinedControlPointsTangentScale");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SerializableVector3 : ValueType {
        
        private float xField;
        
        private float yField;
        
        private float zField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("X");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("Y");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("Z");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SerializableQuaternion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Quaternion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Vector3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SerializableVector3))]
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
    public partial class SerializableQuaternion : ValueType {
        
        private float xField;
        
        private float yField;
        
        private float zField;
        
        private float wField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("X");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("Y");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("Z");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float W {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
                this.RaisePropertyChanged("W");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Quaternion : ValueType {
        
        private float xField;
        
        private float yField;
        
        private float zField;
        
        private float wField;
        
        private Vector3 eulerAnglesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float w {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
                this.RaisePropertyChanged("w");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vector3 eulerAngles {
            get {
                return this.eulerAnglesField;
            }
            set {
                this.eulerAnglesField = value;
                this.RaisePropertyChanged("eulerAngles");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Vector3 : ValueType {
        
        private float xField;
        
        private float yField;
        
        private float zField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
                this.RaisePropertyChanged("x");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
                this.RaisePropertyChanged("y");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
                this.RaisePropertyChanged("z");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierPathDetailedInterpolation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BezierPathDetailed : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SerializableVector3[] controlPointField;
        
        private ArcData previousPathLinkedArcField;
        
        private TurnSpeedConstraint turnSpeedConstraintField;
        
        private SerializableQuaternion initialRotationField;
        
        private SerializableQuaternion finalRotationField;
        
        private float precisionStepField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlPoint", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerializableVector3[] ControlPoint {
            get {
                return this.controlPointField;
            }
            set {
                this.controlPointField = value;
                this.RaisePropertyChanged("ControlPoint");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArcData PreviousPathLinkedArc {
            get {
                return this.previousPathLinkedArcField;
            }
            set {
                this.previousPathLinkedArcField = value;
                this.RaisePropertyChanged("PreviousPathLinkedArc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TurnSpeedConstraint TurnSpeedConstraint {
            get {
                return this.turnSpeedConstraintField;
            }
            set {
                this.turnSpeedConstraintField = value;
                this.RaisePropertyChanged("TurnSpeedConstraint");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerializableQuaternion InitialRotation {
            get {
                return this.initialRotationField;
            }
            set {
                this.initialRotationField = value;
                this.RaisePropertyChanged("InitialRotation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerializableQuaternion FinalRotation {
            get {
                return this.finalRotationField;
            }
            set {
                this.finalRotationField = value;
                this.RaisePropertyChanged("FinalRotation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float PrecisionStep {
            get {
                return this.precisionStepField;
            }
            set {
                this.precisionStepField = value;
                this.RaisePropertyChanged("PrecisionStep");
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
    public partial class ArcData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Vector3 positionField;
        
        private Quaternion rotationField;
        
        private int indexField;
        
        private float lengthField;
        
        private float accumulatedLengthField;
        
        private float relativeAngleField;
        
        private float speedFactorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Vector3 Position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("Position");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Quaternion Rotation {
            get {
                return this.rotationField;
            }
            set {
                this.rotationField = value;
                this.RaisePropertyChanged("Rotation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
                this.RaisePropertyChanged("Index");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
                this.RaisePropertyChanged("Length");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float AccumulatedLength {
            get {
                return this.accumulatedLengthField;
            }
            set {
                this.accumulatedLengthField = value;
                this.RaisePropertyChanged("AccumulatedLength");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float RelativeAngle {
            get {
                return this.relativeAngleField;
            }
            set {
                this.relativeAngleField = value;
                this.RaisePropertyChanged("RelativeAngle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float SpeedFactor {
            get {
                return this.speedFactorField;
            }
            set {
                this.speedFactorField = value;
                this.RaisePropertyChanged("SpeedFactor");
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
    public partial class TurnSpeedConstraint : object, System.ComponentModel.INotifyPropertyChanged {
        
        private float criticalAngleField;
        
        private float criticalAngleSpeedFactorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float CriticalAngle {
            get {
                return this.criticalAngleField;
            }
            set {
                this.criticalAngleField = value;
                this.RaisePropertyChanged("CriticalAngle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float CriticalAngleSpeedFactor {
            get {
                return this.criticalAngleSpeedFactorField;
            }
            set {
                this.criticalAngleSpeedFactorField = value;
                this.RaisePropertyChanged("CriticalAngleSpeedFactor");
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
    public partial class EncounterFlotillaMatchDefinition : DatatableElement {
        
        private EncounterFlotillaTrajectoryDefinition attackerTrajectoryField;
        
        private EncounterFlotillaTrajectoryDefinition defenderTrajectoryField;
        
        private EncounterFlotillaMatchTargetingRangeDefinition[] targetingRangesField;
        
        private string attackerOptimalRangeNameField;
        
        private string defenderOptimalRangeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EncounterFlotillaTrajectoryDefinition AttackerTrajectory {
            get {
                return this.attackerTrajectoryField;
            }
            set {
                this.attackerTrajectoryField = value;
                this.RaisePropertyChanged("AttackerTrajectory");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EncounterFlotillaTrajectoryDefinition DefenderTrajectory {
            get {
                return this.defenderTrajectoryField;
            }
            set {
                this.defenderTrajectoryField = value;
                this.RaisePropertyChanged("DefenderTrajectory");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TargetingRange", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public EncounterFlotillaMatchTargetingRangeDefinition[] TargetingRanges {
            get {
                return this.targetingRangesField;
            }
            set {
                this.targetingRangesField = value;
                this.RaisePropertyChanged("TargetingRanges");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttackerOptimalRangeName {
            get {
                return this.attackerOptimalRangeNameField;
            }
            set {
                this.attackerOptimalRangeNameField = value;
                this.RaisePropertyChanged("AttackerOptimalRangeName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefenderOptimalRangeName {
            get {
                return this.defenderOptimalRangeNameField;
            }
            set {
                this.defenderOptimalRangeNameField = value;
                this.RaisePropertyChanged("DefenderOptimalRangeName");
            }
        }
    }
}
