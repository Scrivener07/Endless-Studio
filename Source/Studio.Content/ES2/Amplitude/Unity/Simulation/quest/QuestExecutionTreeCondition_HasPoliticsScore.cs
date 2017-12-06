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
	public class QuestExecutionTreeCondition_HasPoliticsScore : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_PoliticsNameField;

		private QuestInputArgument input_MinimumPercentageField;

		private QuestInputArgument input_MinimumSystemAmountField;

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
		public QuestInputArgument Input_PoliticsName
		{
			get
			{
				return this.input_PoliticsNameField;
			}
			set
			{
				this.input_PoliticsNameField = value;
				this.RaisePropertyChanged("Input_PoliticsName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumPercentage
		{
			get
			{
				return this.input_MinimumPercentageField;
			}
			set
			{
				this.input_MinimumPercentageField = value;
				this.RaisePropertyChanged("Input_MinimumPercentage");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumSystemAmount
		{
			get
			{
				return this.input_MinimumSystemAmountField;
			}
			set
			{
				this.input_MinimumSystemAmountField = value;
				this.RaisePropertyChanged("Input_MinimumSystemAmount");
			}
		}
	}

}