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
	public class QuestExecutionTreeDecorator_SystemGainedFromInfluence : QuestExecutionTreeDecorator_EmpireEventOfEventSystemGainedFromInfluence
	{

		private QuestOutputArgument output_NodeField;

		private QuestOutputArgument output_ColonizedStarSystemField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Node
		{
			get
			{
				return this.output_NodeField;
			}
			set
			{
				this.output_NodeField = value;
				this.RaisePropertyChanged("Output_Node");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_ColonizedStarSystem
		{
			get
			{
				return this.output_ColonizedStarSystemField;
			}
			set
			{
				this.output_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Output_ColonizedStarSystem");
			}
		}
	}

}