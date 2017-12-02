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
	public class QuestExecutionTreeCondition_HasTradeRoutes : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_TradeRouteAmountField;

		private QuestInputArgument input_ExternalSubsidiariesAmountField;

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
		public QuestInputArgument Input_TradeRouteAmount
		{
			get
			{
				return this.input_TradeRouteAmountField;
			}
			set
			{
				this.input_TradeRouteAmountField = value;
				this.RaisePropertyChanged("Input_TradeRouteAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ExternalSubsidiariesAmount
		{
			get
			{
				return this.input_ExternalSubsidiariesAmountField;
			}
			set
			{
				this.input_ExternalSubsidiariesAmountField = value;
				this.RaisePropertyChanged("Input_ExternalSubsidiariesAmount");
			}
		}
	}

}