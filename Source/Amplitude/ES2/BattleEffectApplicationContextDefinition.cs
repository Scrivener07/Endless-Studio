namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BattleEffectApplicationContextDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Prerequisite[] itemsField;

		private BattleEffectTargetFilterDefinition targetFilterField;

		private XmlNamedReference[] battleEffectReferenceField;


		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
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


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public BattleEffectTargetFilterDefinition TargetFilter
		{
			get
			{
				return this.targetFilterField;
			}
			set
			{
				this.targetFilterField = value;
				this.RaisePropertyChanged("TargetFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("BattleEffectReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] BattleEffectReference
		{
			get
			{
				return this.battleEffectReferenceField;
			}
			set
			{
				this.battleEffectReferenceField = value;
				this.RaisePropertyChanged("BattleEffectReference");
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
