using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestObjectiveDefinition : INotifyPropertyChanged
	{

		private QuestAIHintDefinition aIHintField;

		private QuestExecutionTreeController[] itemsField;

		private QuestOutcomeDefinition[] outcomeField;

		private string startValueField;

		private string endValueField;

		private QuestProgressionType progressionTypeField;

		private bool refreshEndValueField;

		private string nameField;

		public QuestObjectiveDefinition()
		{
			this.startValueField = "";
			this.endValueField = "";
			this.progressionTypeField = QuestProgressionType.Ascending;
			this.refreshEndValueField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestAIHintDefinition AIHint
		{
			get
			{
				return this.aIHintField;
			}
			set
			{
				this.aIHintField = value;
				this.RaisePropertyChanged("AIHint");
			}
		}

		/// <remarks/>
		[XmlElement("Loop", typeof(QuestExecutionTreeController_Loop), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Parallel", typeof(QuestExecutionTreeController_Parallel), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Sequence", typeof(QuestExecutionTreeController_Sequence), Form = XmlSchemaForm.Unqualified)]
		public QuestExecutionTreeController[] Items
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

		/// <remarks/>
		[XmlElement("Outcome", Form = XmlSchemaForm.Unqualified)]
		public QuestOutcomeDefinition[] Outcome
		{
			get
			{
				return this.outcomeField;
			}
			set
			{
				this.outcomeField = value;
				this.RaisePropertyChanged("Outcome");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string StartValue
		{
			get
			{
				return this.startValueField;
			}
			set
			{
				this.startValueField = value;
				this.RaisePropertyChanged("StartValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string EndValue
		{
			get
			{
				return this.endValueField;
			}
			set
			{
				this.endValueField = value;
				this.RaisePropertyChanged("EndValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(QuestProgressionType.Ascending)]
		public QuestProgressionType ProgressionType
		{
			get
			{
				return this.progressionTypeField;
			}
			set
			{
				this.progressionTypeField = value;
				this.RaisePropertyChanged("ProgressionType");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool RefreshEndValue
		{
			get
			{
				return this.refreshEndValueField;
			}
			set
			{
				this.refreshEndValueField = value;
				this.RaisePropertyChanged("RefreshEndValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}

}