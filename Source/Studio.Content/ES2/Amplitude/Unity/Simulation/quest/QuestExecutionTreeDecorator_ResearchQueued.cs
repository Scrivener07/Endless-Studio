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
	public class QuestExecutionTreeDecorator_ResearchQueued : QuestExecutionTreeDecorator_EmpireEventOfEventResearchQueued
	{

		private QuestInputArgument input_ResearchNameField;

		private QuestInputArgument input_MinimumAmountInQueueField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ResearchName
		{
			get
			{
				return this.input_ResearchNameField;
			}
			set
			{
				this.input_ResearchNameField = value;
				this.RaisePropertyChanged("Input_ResearchName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumAmountInQueue
		{
			get
			{
				return this.input_MinimumAmountInQueueField;
			}
			set
			{
				this.input_MinimumAmountInQueueField = value;
				this.RaisePropertyChanged("Input_MinimumAmountInQueue");
			}
		}
	}

}