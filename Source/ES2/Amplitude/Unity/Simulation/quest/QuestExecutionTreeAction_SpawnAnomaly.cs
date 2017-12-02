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
	public class QuestExecutionTreeAction_SpawnAnomaly : QuestExecutionTreeAction
	{

		private QuestInputArgument input_PlanetsField;

		private QuestInputArgument input_AnomalyDefinitionField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Planets
		{
			get
			{
				return this.input_PlanetsField;
			}
			set
			{
				this.input_PlanetsField = value;
				this.RaisePropertyChanged("Input_Planets");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_AnomalyDefinition
		{
			get
			{
				return this.input_AnomalyDefinitionField;
			}
			set
			{
				this.input_AnomalyDefinitionField = value;
				this.RaisePropertyChanged("Input_AnomalyDefinition");
			}
		}
	}

}