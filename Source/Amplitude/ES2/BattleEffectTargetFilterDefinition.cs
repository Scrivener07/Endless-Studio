namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BattleEffectTargetFilterDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private EncounterEntityFilterDefinition_BattleActionRole entityFilterField;

		private EncounterEntityFilterDefinition parentEntityFilterField;

		private SubEntityFilterDefinition subEntityFilterField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncounterEntityFilterDefinition_BattleActionRole EntityFilter
		{
			get
			{
				return this.entityFilterField;
			}
			set
			{
				this.entityFilterField = value;
				this.RaisePropertyChanged("EntityFilter");
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
