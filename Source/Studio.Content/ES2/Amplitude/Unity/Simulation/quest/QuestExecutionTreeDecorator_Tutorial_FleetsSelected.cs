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
	public class QuestExecutionTreeDecorator_Tutorial_FleetsSelected : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_FleetsSelected
	{

		private QuestInputArgument input_FleetField;

		private QuestInputArgument input_FleetGUIDField;

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
		public QuestInputArgument Input_FleetGUID
		{
			get
			{
				return this.input_FleetGUIDField;
			}
			set
			{
				this.input_FleetGUIDField = value;
				this.RaisePropertyChanged("Input_FleetGUID");
			}
		}
	}

}