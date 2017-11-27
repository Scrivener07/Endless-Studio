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
namespace ES2.XSD.Generator.Definitions.GalaxyShapeMergePlans_SCHEMA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SizeDivisionUseCase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sizeField;
        
        private string divisionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
                this.RaisePropertyChanged("Size");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Division {
            get {
                return this.divisionField;
            }
            set {
                this.divisionField = value;
                this.RaisePropertyChanged("Division");
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
    public partial class MergePlan : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SizeDivisionUseCase[] useCaseField;
        
        private string[][] blockField;
        
        private string nameField;
        
        private int majorSpawnBlocksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UseCase", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SizeDivisionUseCase[] UseCase {
            get {
                return this.useCaseField;
            }
            set {
                this.useCaseField = value;
                this.RaisePropertyChanged("UseCase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TakenShape", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[][] Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
                this.RaisePropertyChanged("Block");
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
        public int MajorSpawnBlocks {
            get {
                return this.majorSpawnBlocksField;
            }
            set {
                this.majorSpawnBlocksField = value;
                this.RaisePropertyChanged("MajorSpawnBlocks");
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
    public partial class GalaxyShapeMergePlans : object, System.ComponentModel.INotifyPropertyChanged {
        
        private MergePlan[] mergePlanField;
        
        private string shapeNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MergePlan", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MergePlan[] MergePlan {
            get {
                return this.mergePlanField;
            }
            set {
                this.mergePlanField = value;
                this.RaisePropertyChanged("MergePlan");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShapeName {
            get {
                return this.shapeNameField;
            }
            set {
                this.shapeNameField = value;
                this.RaisePropertyChanged("ShapeName");
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
