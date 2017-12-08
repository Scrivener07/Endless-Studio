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
	public class QuestExecutionTreeCondition_ExplorationProgress : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_PercentageField;

		private State minimumStateField;

		public QuestExecutionTreeCondition_ExplorationProgress()
		{
			this.minimumStateField = State.Revealed;
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
		public QuestInputArgument Input_Percentage
		{
			get
			{
				return this.input_PercentageField;
			}
			set
			{
				this.input_PercentageField = value;
				this.RaisePropertyChanged("Input_Percentage");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(State.Revealed)]
		public State MinimumState
		{
			get
			{
				return this.minimumStateField;
			}
			set
			{
				this.minimumStateField = value;
				this.RaisePropertyChanged("MinimumState");
			}
		}
	}

}