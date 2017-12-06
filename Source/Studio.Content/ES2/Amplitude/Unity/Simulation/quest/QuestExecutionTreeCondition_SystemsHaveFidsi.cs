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
	public class QuestExecutionTreeCondition_SystemsHaveFidsi : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_SystemCountField;

		private QuestInputArgument input_NetGrowthField;

		private QuestInputArgument input_NetProductionField;

		private QuestInputArgument input_NetMoneyField;

		private QuestInputArgument input_NetResearchField;

		private QuestInputArgument input_NetEmpirePointField;

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
		public QuestInputArgument Input_SystemCount
		{
			get
			{
				return this.input_SystemCountField;
			}
			set
			{
				this.input_SystemCountField = value;
				this.RaisePropertyChanged("Input_SystemCount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NetGrowth
		{
			get
			{
				return this.input_NetGrowthField;
			}
			set
			{
				this.input_NetGrowthField = value;
				this.RaisePropertyChanged("Input_NetGrowth");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NetProduction
		{
			get
			{
				return this.input_NetProductionField;
			}
			set
			{
				this.input_NetProductionField = value;
				this.RaisePropertyChanged("Input_NetProduction");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NetMoney
		{
			get
			{
				return this.input_NetMoneyField;
			}
			set
			{
				this.input_NetMoneyField = value;
				this.RaisePropertyChanged("Input_NetMoney");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NetResearch
		{
			get
			{
				return this.input_NetResearchField;
			}
			set
			{
				this.input_NetResearchField = value;
				this.RaisePropertyChanged("Input_NetResearch");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NetEmpirePoint
		{
			get
			{
				return this.input_NetEmpirePointField;
			}
			set
			{
				this.input_NetEmpirePointField = value;
				this.RaisePropertyChanged("Input_NetEmpirePoint");
			}
		}
	}

}