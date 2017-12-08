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
	public class QuestExecutionTreeCondition_ManpowerDistribution : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumInfantryPercentField;

		private QuestInputArgument input_MaximumInfantryPercentField;

		private QuestInputArgument input_MinimumTankPercentField;

		private QuestInputArgument input_MaximumTankPercentField;

		private QuestInputArgument input_MinimumPlanePercentField;

		private QuestInputArgument input_MaximumPlanePercentField;

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
		public QuestInputArgument Input_MinimumInfantryPercent
		{
			get
			{
				return this.input_MinimumInfantryPercentField;
			}
			set
			{
				this.input_MinimumInfantryPercentField = value;
				this.RaisePropertyChanged("Input_MinimumInfantryPercent");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumInfantryPercent
		{
			get
			{
				return this.input_MaximumInfantryPercentField;
			}
			set
			{
				this.input_MaximumInfantryPercentField = value;
				this.RaisePropertyChanged("Input_MaximumInfantryPercent");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumTankPercent
		{
			get
			{
				return this.input_MinimumTankPercentField;
			}
			set
			{
				this.input_MinimumTankPercentField = value;
				this.RaisePropertyChanged("Input_MinimumTankPercent");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumTankPercent
		{
			get
			{
				return this.input_MaximumTankPercentField;
			}
			set
			{
				this.input_MaximumTankPercentField = value;
				this.RaisePropertyChanged("Input_MaximumTankPercent");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumPlanePercent
		{
			get
			{
				return this.input_MinimumPlanePercentField;
			}
			set
			{
				this.input_MinimumPlanePercentField = value;
				this.RaisePropertyChanged("Input_MinimumPlanePercent");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumPlanePercent
		{
			get
			{
				return this.input_MaximumPlanePercentField;
			}
			set
			{
				this.input_MaximumPlanePercentField = value;
				this.RaisePropertyChanged("Input_MaximumPlanePercent");
			}
		}
	}

}