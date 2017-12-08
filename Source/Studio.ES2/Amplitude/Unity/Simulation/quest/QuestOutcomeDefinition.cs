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
	public class QuestOutcomeDefinition : INotifyPropertyChanged
	{

		private QuestWeightedTriggers[] triggersField;

		private QuestRewardDefinition[] itemsField;

		private string nameField;

		/// <remarks/>
		[XmlElement("Triggers", Form = XmlSchemaForm.Unqualified)]
		public QuestWeightedTriggers[] Triggers
		{
			get
			{
				return this.triggersField;
			}
			set
			{
				this.triggersField = value;
				this.RaisePropertyChanged("Triggers");
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
