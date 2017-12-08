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
	public class QuestExecutionTreeAction_StartTimer : QuestExecutionTreeAction
	{

		private QuestInputArgument input_DurationField;

		private QuestOutputArgument output_TimerField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Duration
		{
			get
			{
				return this.input_DurationField;
			}
			set
			{
				this.input_DurationField = value;
				this.RaisePropertyChanged("Input_Duration");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Timer
		{
			get
			{
				return this.output_TimerField;
			}
			set
			{
				this.output_TimerField = value;
				this.RaisePropertyChanged("Output_Timer");
			}
		}
	}

}