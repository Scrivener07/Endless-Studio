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
	public class QuestExecutionTreeCondition_IsVariableNotEmpty : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_VariableField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Variable
		{
			get
			{
				return this.input_VariableField;
			}
			set
			{
				this.input_VariableField = value;
				this.RaisePropertyChanged("Input_Variable");
			}
		}
	}

}