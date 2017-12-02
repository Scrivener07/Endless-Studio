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
	public class QuestExecutionTreeAction_TriggerPopulationEvent : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_TargetField;

		private QuestInputArgument input_PopulationEventDefinitionField;

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
		public QuestInputArgument Input_Target
		{
			get
			{
				return this.input_TargetField;
			}
			set
			{
				this.input_TargetField = value;
				this.RaisePropertyChanged("Input_Target");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PopulationEventDefinition
		{
			get
			{
				return this.input_PopulationEventDefinitionField;
			}
			set
			{
				this.input_PopulationEventDefinitionField = value;
				this.RaisePropertyChanged("Input_PopulationEventDefinition");
			}
		}
	}

}