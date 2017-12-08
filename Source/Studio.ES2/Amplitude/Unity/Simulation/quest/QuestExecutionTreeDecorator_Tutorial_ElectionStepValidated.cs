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
	public class QuestExecutionTreeDecorator_Tutorial_ElectionStepValidated : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_ElectionStepValidated
	{

		private QuestInputArgument input_StepNumberField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_StepNumber
		{
			get
			{
				return this.input_StepNumberField;
			}
			set
			{
				this.input_StepNumberField = value;
				this.RaisePropertyChanged("Input_StepNumber");
			}
		}
	}

}