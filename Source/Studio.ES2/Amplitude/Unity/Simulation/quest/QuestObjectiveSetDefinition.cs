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
	public class QuestObjectiveSetDefinition : INotifyPropertyChanged
	{

		private QuestVariablesDefinition varsField;

		private QuestStartActionsDefinition startActionsField;

		private QuestObjectiveDefinition[] objectiveField;

		private QuestRewardDefinition[] itemsField;

		private string teamNameField;

		private string dynamicRewardPreviewLocalizationKeyField;

		private QuestObjectiveComposition objectiveCompositionField;

		public QuestObjectiveSetDefinition()
		{
			this.objectiveCompositionField = QuestObjectiveComposition.Any;
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
		[XmlElement("Objective", Form = XmlSchemaForm.Unqualified)]
		public QuestObjectiveDefinition[] Objective
		{
			get
			{
				return this.objectiveField;
			}
			set
			{
				this.objectiveField = value;
				this.RaisePropertyChanged("Objective");
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
		public string TeamName
		{
			get
			{
				return this.teamNameField;
			}
			set
			{
				this.teamNameField = value;
				this.RaisePropertyChanged("TeamName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string DynamicRewardPreviewLocalizationKey
		{
			get
			{
				return this.dynamicRewardPreviewLocalizationKeyField;
			}
			set
			{
				this.dynamicRewardPreviewLocalizationKeyField = value;
				this.RaisePropertyChanged("DynamicRewardPreviewLocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(QuestObjectiveComposition.Any)]
		public QuestObjectiveComposition ObjectiveComposition
		{
			get
			{
				return this.objectiveCompositionField;
			}
			set
			{
				this.objectiveCompositionField = value;
				this.RaisePropertyChanged("ObjectiveComposition");
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