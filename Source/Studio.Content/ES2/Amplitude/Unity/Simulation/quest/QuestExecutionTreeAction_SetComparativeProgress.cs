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
	public class QuestExecutionTreeAction_SetComparativeProgress : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_ExpressionField;

		private bool setProgressStartField;

		private bool setProgressEndAsBestValueField;

		private ProgressCalculation progressCalculationField;

		public QuestExecutionTreeAction_SetComparativeProgress()
		{
			this.setProgressStartField = false;
			this.setProgressEndAsBestValueField = false;
			this.progressCalculationField = ProgressCalculation.Best;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empires
		{
			get
			{
				return this.input_EmpiresField;
			}
			set
			{
				this.input_EmpiresField = value;
				this.RaisePropertyChanged("Input_Empires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Expression
		{
			get
			{
				return this.input_ExpressionField;
			}
			set
			{
				this.input_ExpressionField = value;
				this.RaisePropertyChanged("Input_Expression");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool SetProgressStart
		{
			get
			{
				return this.setProgressStartField;
			}
			set
			{
				this.setProgressStartField = value;
				this.RaisePropertyChanged("SetProgressStart");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool SetProgressEndAsBestValue
		{
			get
			{
				return this.setProgressEndAsBestValueField;
			}
			set
			{
				this.setProgressEndAsBestValueField = value;
				this.RaisePropertyChanged("SetProgressEndAsBestValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(ProgressCalculation.Best)]
		public ProgressCalculation ProgressCalculation
		{
			get
			{
				return this.progressCalculationField;
			}
			set
			{
				this.progressCalculationField = value;
				this.RaisePropertyChanged("ProgressCalculation");
			}
		}
	}

}