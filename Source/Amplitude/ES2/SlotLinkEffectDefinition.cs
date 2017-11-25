namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SlotLinkEffectDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SlotLinkModuleConstraintDefinition[] moduleConstraintField;

		private ModuleModifierDefinition[] moduleModifierField;


		[System.Xml.Serialization.XmlElementAttribute("ModuleConstraint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SlotLinkModuleConstraintDefinition[] ModuleConstraint
		{
			get
			{
				return this.moduleConstraintField;
			}
			set
			{
				this.moduleConstraintField = value;
				this.RaisePropertyChanged("ModuleConstraint");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ModuleModifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ModuleModifierDefinition[] ModuleModifier
		{
			get
			{
				return this.moduleModifierField;
			}
			set
			{
				this.moduleModifierField = value;
				this.RaisePropertyChanged("ModuleModifier");
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
