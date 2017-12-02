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
	public class QuestExecutionTreeAction_TruncateVariable : QuestExecutionTreeAction
	{

		private QuestInputArgument input_VariableField;

		private QuestInputArgument input_CountField;

		private QuestOutputArgument output_VariableField;

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

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Count
		{
			get
			{
				return this.input_CountField;
			}
			set
			{
				this.input_CountField = value;
				this.RaisePropertyChanged("Input_Count");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Variable
		{
			get
			{
				return this.output_VariableField;
			}
			set
			{
				this.output_VariableField = value;
				this.RaisePropertyChanged("Output_Variable");
			}
		}
	}

}