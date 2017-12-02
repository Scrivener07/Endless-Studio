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
	public class QuestExecutionTreeAction_SpawnPopulation : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_SystemField;

		private QuestOutputArgument input_AmountField;

		private QuestOutputArgument input_PopulationAffinityField;

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
		public QuestInputArgument Input_System
		{
			get
			{
				return this.input_SystemField;
			}
			set
			{
				this.input_SystemField = value;
				this.RaisePropertyChanged("Input_System");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Input_Amount
		{
			get
			{
				return this.input_AmountField;
			}
			set
			{
				this.input_AmountField = value;
				this.RaisePropertyChanged("Input_Amount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Input_PopulationAffinity
		{
			get
			{
				return this.input_PopulationAffinityField;
			}
			set
			{
				this.input_PopulationAffinityField = value;
				this.RaisePropertyChanged("Input_PopulationAffinity");
			}
		}
	}

}