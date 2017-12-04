using ES2.Amplitude.Unity.Framework;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestStatePrerequisite : Prerequisite
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
		[XmlAttribute]
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
		[XmlAttribute]
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
		[XmlAttribute]
		[DefaultValue("")]
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
		[XmlAttribute]
		[DefaultValue(QuestState.Completed)]
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
