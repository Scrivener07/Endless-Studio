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
	public class QuestExecutionTreeCondition_HasSystemDefense : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_ColonizedStarSystemField;

		private QuestInputArgument input_MinimumDefenseField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ColonizedStarSystem
		{
			get
			{
				return this.input_ColonizedStarSystemField;
			}
			set
			{
				this.input_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Input_ColonizedStarSystem");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumDefense
		{
			get
			{
				return this.input_MinimumDefenseField;
			}
			set
			{
				this.input_MinimumDefenseField = value;
				this.RaisePropertyChanged("Input_MinimumDefense");
			}
		}
	}

}