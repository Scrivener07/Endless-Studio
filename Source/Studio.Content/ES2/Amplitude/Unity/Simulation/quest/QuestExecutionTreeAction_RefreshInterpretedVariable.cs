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
	public class QuestExecutionTreeAction_RefreshInterpretedVariable : QuestExecutionTreeAction
	{

		private QuestOutputArgument output_InterpretedVarField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_InterpretedVar
		{
			get
			{
				return this.output_InterpretedVarField;
			}
			set
			{
				this.output_InterpretedVarField = value;
				this.RaisePropertyChanged("Output_InterpretedVar");
			}
		}
	}

}