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
	public class QuestStepDefinition : INotifyPropertyChanged
	{
		private QuestStepChoiceDefinition choiceField;

		private QuestVariablesDefinition varsField;

		private QuestStartActionsDefinition startActionsField;

		private QuestObjectiveSetDefinition[] objectiveSetField;

		private QuestRewardDefinition[] itemsField;

		private string nameField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestStepChoiceDefinition Choice
		{
			get
			{
				return this.choiceField;
			}
			set
			{
				this.choiceField = value;
				this.RaisePropertyChanged("Choice");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestVariablesDefinition Vars
		{
			get
			{
				return this.varsField;
			}
			set
			{
				this.varsField = value;
				this.RaisePropertyChanged("Vars");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestStartActionsDefinition StartActions
		{
			get
			{
				return this.startActionsField;
			}
			set
			{
				this.startActionsField = value;
				this.RaisePropertyChanged("StartActions");
			}
		}

		/// <remarks/>
		[XmlElement("ObjectiveSet", Form = XmlSchemaForm.Unqualified)]
		public QuestObjectiveSetDefinition[] ObjectiveSet
		{
			get
			{
				return this.objectiveSetField;
			}
			set
			{
				this.objectiveSetField = value;
				this.RaisePropertyChanged("ObjectiveSet");
			}
		}

		/// <remarks/>
		[XmlElement("PodiumReward", typeof(QuestPodiumRewardDefinition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Reward", typeof(QuestRewardItemDefinition), Form = XmlSchemaForm.Unqualified)]
		public QuestRewardDefinition[] Items
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
