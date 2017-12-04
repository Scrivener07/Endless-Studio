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
	public class QuestExecutionTreeCondition_CheckDiplomaticRelation : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_OtherEmpireField;

		private QuestInputArgument input_DiplomaticRelationStateField;

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
		public QuestInputArgument Input_OtherEmpire
		{
			get
			{
				return this.input_OtherEmpireField;
			}
			set
			{
				this.input_OtherEmpireField = value;
				this.RaisePropertyChanged("Input_OtherEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DiplomaticRelationState
		{
			get
			{
				return this.input_DiplomaticRelationStateField;
			}
			set
			{
				this.input_DiplomaticRelationStateField = value;
				this.RaisePropertyChanged("Input_DiplomaticRelationState");
			}
		}
	}

}