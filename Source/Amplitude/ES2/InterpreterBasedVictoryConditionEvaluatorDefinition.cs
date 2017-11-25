namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class InterpreterBasedVictoryConditionEvaluatorDefinition : VictoryConditionEvaluatorDefinition
	{

		private VictoryDefinitionFormula scoreFormulaField;

		private VictoryDefinitionFormula progressFormulaField;

		private VictoryDefinitionFormula discreteProgressFormulaField;

		private VictoryDefinitionFormula discreteObjectiveFormulaField;

		private string victoryExpressionField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public VictoryDefinitionFormula ScoreFormula
		{
			get
			{
				return this.scoreFormulaField;
			}
			set
			{
				this.scoreFormulaField = value;
				this.RaisePropertyChanged("ScoreFormula");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public VictoryDefinitionFormula ProgressFormula
		{
			get
			{
				return this.progressFormulaField;
			}
			set
			{
				this.progressFormulaField = value;
				this.RaisePropertyChanged("ProgressFormula");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public VictoryDefinitionFormula DiscreteProgressFormula
		{
			get
			{
				return this.discreteProgressFormulaField;
			}
			set
			{
				this.discreteProgressFormulaField = value;
				this.RaisePropertyChanged("DiscreteProgressFormula");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public VictoryDefinitionFormula DiscreteObjectiveFormula
		{
			get
			{
				return this.discreteObjectiveFormulaField;
			}
			set
			{
				this.discreteObjectiveFormulaField = value;
				this.RaisePropertyChanged("DiscreteObjectiveFormula");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string VictoryExpression
		{
			get
			{
				return this.victoryExpressionField;
			}
			set
			{
				this.victoryExpressionField = value;
				this.RaisePropertyChanged("VictoryExpression");
			}
		}
	}
}
