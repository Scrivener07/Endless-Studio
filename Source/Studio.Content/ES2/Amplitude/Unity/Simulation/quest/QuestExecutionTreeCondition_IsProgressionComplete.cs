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
	public class QuestExecutionTreeCondition_IsProgressionComplete : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_ContextField;

		private QuestInputArgument input_EmpireWhoseProgressToUpdateField;

		private QuestInputArgument input_ExpressionField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Context
		{
			get
			{
				return this.input_ContextField;
			}
			set
			{
				this.input_ContextField = value;
				this.RaisePropertyChanged("Input_Context");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_EmpireWhoseProgressToUpdate
		{
			get
			{
				return this.input_EmpireWhoseProgressToUpdateField;
			}
			set
			{
				this.input_EmpireWhoseProgressToUpdateField = value;
				this.RaisePropertyChanged("Input_EmpireWhoseProgressToUpdate");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Expression
		{
			get
			{
				return this.input_ExpressionField;
			}
			set
			{
				this.input_ExpressionField = value;
				this.RaisePropertyChanged("Input_Expression");
			}
		}
	}

}