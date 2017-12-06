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
	public class QuestExecutionTreeDecorator_ProbeLaunched : QuestExecutionTreeDecorator_EmpireEventOfEventProbeLaunched
	{

		private QuestInputArgument input_FleetField;

		private QuestOutputArgument output_FleetField;

		private QuestOutputArgument output_FleetGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleet
		{
			get
			{
				return this.input_FleetField;
			}
			set
			{
				this.input_FleetField = value;
				this.RaisePropertyChanged("Input_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Fleet
		{
			get
			{
				return this.output_FleetField;
			}
			set
			{
				this.output_FleetField = value;
				this.RaisePropertyChanged("Output_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_FleetGUID
		{
			get
			{
				return this.output_FleetGUIDField;
			}
			set
			{
				this.output_FleetGUIDField = value;
				this.RaisePropertyChanged("Output_FleetGUID");
			}
		}
	}

}