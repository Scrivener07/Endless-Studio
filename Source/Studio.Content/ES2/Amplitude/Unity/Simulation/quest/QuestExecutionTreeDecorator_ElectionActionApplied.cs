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
	public class QuestExecutionTreeDecorator_ElectionActionApplied : QuestExecutionTreeDecorator_EmpireEventOfEventElectionActionApplied
	{

		private QuestInputArgument input_ActionNameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ActionName
		{
			get
			{
				return this.input_ActionNameField;
			}
			set
			{
				this.input_ActionNameField = value;
				this.RaisePropertyChanged("Input_ActionName");
			}
		}
	}

}