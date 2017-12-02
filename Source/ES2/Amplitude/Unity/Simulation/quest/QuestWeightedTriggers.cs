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
	public class QuestWeightedTriggers : INotifyPropertyChanged
	{

		private QuestQuestTrigger[] questTriggerField;

		private int weightField;

		public QuestWeightedTriggers()
		{
			this.weightField = 1;
		}

		/// <remarks/>
		[XmlElement("QuestTrigger", Form = XmlSchemaForm.Unqualified)]
		public QuestQuestTrigger[] QuestTrigger
		{
			get
			{
				return this.questTriggerField;
			}
			set
			{
				this.questTriggerField = value;
				this.RaisePropertyChanged("QuestTrigger");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(1)]
		public int Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
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
