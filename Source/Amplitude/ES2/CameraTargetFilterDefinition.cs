namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraTargetFilterDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private CameraTargetSelectionMethodDefinition[] itemsField;

		private Prerequisite[] items1Field;

		private EncounterEntityFilterDefinition parentEntityFilterField;

		private SubEntityFilterDefinition subEntityFilterField;

		private bool attachedToTargetField;

		private bool lookAtTargetPositionAlterationField;

		private bool ignoreTargetStatusField;

		public CameraTargetFilterDefinition()
		{
			this.attachedToTargetField = false;
			this.lookAtTargetPositionAlterationField = false;
			this.ignoreTargetStatusField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute("SelectionMethod_EncounterEntity", typeof(CameraTargetSelectionMethodDefinition_EncounterEntity), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SelectionMethod_Name", typeof(CameraTargetSelectionMethodDefinition_Name), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetSelectionMethodDefinition[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items1
		{
			get
			{
				return this.items1Field;
			}
			set
			{
				this.items1Field = value;
				this.RaisePropertyChanged("Items1");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEntityFilterDefinition ParentEntityFilter
		{
			get
			{
				return this.parentEntityFilterField;
			}
			set
			{
				this.parentEntityFilterField = value;
				this.RaisePropertyChanged("ParentEntityFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SubEntityFilterDefinition SubEntityFilter
		{
			get
			{
				return this.subEntityFilterField;
			}
			set
			{
				this.subEntityFilterField = value;
				this.RaisePropertyChanged("SubEntityFilter");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool AttachedToTarget
		{
			get
			{
				return this.attachedToTargetField;
			}
			set
			{
				this.attachedToTargetField = value;
				this.RaisePropertyChanged("AttachedToTarget");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool LookAtTargetPositionAlteration
		{
			get
			{
				return this.lookAtTargetPositionAlterationField;
			}
			set
			{
				this.lookAtTargetPositionAlterationField = value;
				this.RaisePropertyChanged("LookAtTargetPositionAlteration");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IgnoreTargetStatus
		{
			get
			{
				return this.ignoreTargetStatusField;
			}
			set
			{
				this.ignoreTargetStatusField = value;
				this.RaisePropertyChanged("IgnoreTargetStatus");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
