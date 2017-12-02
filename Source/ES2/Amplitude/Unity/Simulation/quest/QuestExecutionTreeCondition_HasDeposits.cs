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
	public class QuestExecutionTreeCondition_HasDeposits : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MaximumAmountField;

		private DepositResourceType input_ResourceTypeField;

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
		public QuestInputArgument Input_MaximumAmount
		{
			get
			{
				return this.input_MaximumAmountField;
			}
			set
			{
				this.input_MaximumAmountField = value;
				this.RaisePropertyChanged("Input_MaximumAmount");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public DepositResourceType Input_ResourceType
		{
			get
			{
				return this.input_ResourceTypeField;
			}
			set
			{
				this.input_ResourceTypeField = value;
				this.RaisePropertyChanged("Input_ResourceType");
			}
		}
	}

}