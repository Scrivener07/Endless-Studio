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
	public class QuestExecutionTreeCondition_IsFleetDockedOnNode : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_FleetGUIDField;

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_SystemsField;

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

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empire
		{
			get
			{
				return this.input_EmpireField;
			}
			set
			{
				this.input_EmpireField = value;
				this.RaisePropertyChanged("Input_Empire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Systems
		{
			get
			{
				return this.input_SystemsField;
			}
			set
			{
				this.input_SystemsField = value;
				this.RaisePropertyChanged("Input_Systems");
			}
		}
	}

}