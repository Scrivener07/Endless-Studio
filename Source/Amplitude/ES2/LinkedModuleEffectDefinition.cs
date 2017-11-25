namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class LinkedModuleEffectDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SlotLinkModuleConstraintDefinition linkedModuleConstraintField;

		private ModuleModifierDefinition ownModifierField;

		private ModuleModifierDefinition linkedModuleModifierField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotLinkModuleConstraintDefinition LinkedModuleConstraint
		{
			get
			{
				return this.linkedModuleConstraintField;
			}
			set
			{
				this.linkedModuleConstraintField = value;
				this.RaisePropertyChanged("LinkedModuleConstraint");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ModuleModifierDefinition OwnModifier
		{
			get
			{
				return this.ownModifierField;
			}
			set
			{
				this.ownModifierField = value;
				this.RaisePropertyChanged("OwnModifier");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ModuleModifierDefinition LinkedModuleModifier
		{
			get
			{
				return this.linkedModuleModifierField;
			}
			set
			{
				this.linkedModuleModifierField = value;
				this.RaisePropertyChanged("LinkedModuleModifier");
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
