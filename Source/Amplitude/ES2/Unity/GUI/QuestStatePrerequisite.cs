namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class QuestStatePrerequisite : Prerequisite
	{

		private string questDefinitionNameField;

		private QuestState questStateField;

		private string questStepNameField;

		private QuestState questStepStateField;

		public QuestStatePrerequisite()
		{
			this.questStepNameField = "";
			this.questStepStateField = QuestState.Completed;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string QuestDefinitionName
		{
			get
			{
				return this.questDefinitionNameField;
			}
			set
			{
				this.questDefinitionNameField = value;
				this.RaisePropertyChanged("QuestDefinitionName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public QuestState QuestState
		{
			get
			{
				return this.questStateField;
			}
			set
			{
				this.questStateField = value;
				this.RaisePropertyChanged("QuestState");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string QuestStepName
		{
			get
			{
				return this.questStepNameField;
			}
			set
			{
				this.questStepNameField = value;
				this.RaisePropertyChanged("QuestStepName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(QuestState.Completed)]
		public QuestState QuestStepState
		{
			get
			{
				return this.questStepStateField;
			}
			set
			{
				this.questStepStateField = value;
				this.RaisePropertyChanged("QuestStepState");
			}
		}
	}
}
