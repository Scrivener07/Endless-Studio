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
	public class QuestExecutionTreeDecorator_ConstructionQueued : QuestExecutionTreeDecorator_EmpireEventOfEventConstructionQueued
	{

		private QuestInputArgument input_ConstructionNameField;

		private QuestInputArgument input_MinimumAmountInQueueField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ConstructionName
		{
			get
			{
				return this.input_ConstructionNameField;
			}
			set
			{
				this.input_ConstructionNameField = value;
				this.RaisePropertyChanged("Input_ConstructionName");
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