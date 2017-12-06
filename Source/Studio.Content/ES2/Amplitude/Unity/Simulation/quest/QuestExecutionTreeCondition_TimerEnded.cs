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
	public class QuestExecutionTreeCondition_TimerEnded : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_TimerField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Timer
		{
			get
			{
				return this.input_TimerField;
			}
			set
			{
				this.input_TimerField = value;
				this.RaisePropertyChanged("Input_Timer");
			}
		}
	}

}