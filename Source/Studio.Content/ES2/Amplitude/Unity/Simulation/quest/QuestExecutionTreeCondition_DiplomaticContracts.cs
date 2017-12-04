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
	public class QuestExecutionTreeCondition_DiplomaticContracts : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_TargetEmpiresField;

		private QuestInputArgument input_SpecificTermField;

		private DiplomaticContractState contractStateField;

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
		public QuestInputArgument Input_MinimumAmount
		{
			get
			{
				return this.input_MinimumAmountField;
			}
			set
			{
				this.input_MinimumAmountField = value;
				this.RaisePropertyChanged("Input_MinimumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TargetEmpires
		{
			get
			{
				return this.input_TargetEmpiresField;
			}
			set
			{
				this.input_TargetEmpiresField = value;
				this.RaisePropertyChanged("Input_TargetEmpires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SpecificTerm
		{
			get
			{
				return this.input_SpecificTermField;
			}
			set
			{
				this.input_SpecificTermField = value;
				this.RaisePropertyChanged("Input_SpecificTerm");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public DiplomaticContractState ContractState
		{
			get
			{
				return this.contractStateField;
			}
			set
			{
				this.contractStateField = value;
				this.RaisePropertyChanged("ContractState");
			}
		}
	}

}