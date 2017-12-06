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
	public class QuestExecutionTreeCondition_HasPlanets : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireOrSystemField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_PlanetTypeField;

		private QuestInputArgument input_PlanetSizeField;

		private QuestInputArgument input_PlanetGameplayTypeField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_EmpireOrSystem
		{
			get
			{
				return this.input_EmpireOrSystemField;
			}
			set
			{
				this.input_EmpireOrSystemField = value;
				this.RaisePropertyChanged("Input_EmpireOrSystem");
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
		public QuestInputArgument Input_PlanetType
		{
			get
			{
				return this.input_PlanetTypeField;
			}
			set
			{
				this.input_PlanetTypeField = value;
				this.RaisePropertyChanged("Input_PlanetType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PlanetSize
		{
			get
			{
				return this.input_PlanetSizeField;
			}
			set
			{
				this.input_PlanetSizeField = value;
				this.RaisePropertyChanged("Input_PlanetSize");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PlanetGameplayType
		{
			get
			{
				return this.input_PlanetGameplayTypeField;
			}
			set
			{
				this.input_PlanetGameplayTypeField = value;
				this.RaisePropertyChanged("Input_PlanetGameplayType");
			}
		}
	}

}