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
	public class QuestExecutionTreeDecorator_Wait : QuestExecutionTreeDecorator_EndTurn
	{

		private QuestInputArgument input_WaitDurationField;

		private QuestInputArgument input_EndTurnField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_WaitDuration
		{
			get
			{
				return this.input_WaitDurationField;
			}
			set
			{
				this.input_WaitDurationField = value;
				this.RaisePropertyChanged("Input_WaitDuration");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_EndTurn
		{
			get
			{
				return this.input_EndTurnField;
			}
			set
			{
				this.input_EndTurnField = value;
				this.RaisePropertyChanged("Input_EndTurn");
			}
		}
	}

}