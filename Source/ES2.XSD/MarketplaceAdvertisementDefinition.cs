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
namespace ES2.XSD.MarketplaceAdvertisementDefinition_SCHEMA {
    using System.Xml.Serialization;
    
    
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketplaceAdvertisementDefinition))]
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class MarketplaceAdvertisementDefinition : DatatableElement {
        
        private CustomConstructionCost baseCostField;
        
        private CustomConstructionCost costPerTurnField;
        
        private CustomConstructionCost notificationCostField;
        
        private string[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomConstructionCost BaseCost {
            get {
                return this.baseCostField;
            }
            set {
                this.baseCostField = value;
                this.RaisePropertyChanged("BaseCost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomConstructionCost CostPerTurn {
            get {
                return this.costPerTurnField;
            }
            set {
                this.costPerTurnField = value;
                this.RaisePropertyChanged("CostPerTurn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomConstructionCost NotificationCost {
            get {
                return this.notificationCostField;
            }
            set {
                this.notificationCostField = value;
                this.RaisePropertyChanged("NotificationCost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }
    }
}