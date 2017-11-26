namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleEffect_SetPropertyValue : BattleEffect
	{

		private string propertyNameField;

		private OperationType operationField;

		private string interpreterFormulaField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PropertyName
		{
			get
			{
				return this.propertyNameField;
			}
			set
			{
				this.propertyNameField = value;
				this.RaisePropertyChanged("PropertyName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public OperationType Operation
		{
			get
			{
				return this.operationField;
			}
			set
			{
				this.operationField = value;
				this.RaisePropertyChanged("Operation");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InterpreterFormula
		{
			get
			{
				return this.interpreterFormulaField;
			}
			set
			{
				this.interpreterFormulaField = value;
				this.RaisePropertyChanged("InterpreterFormula");
			}
		}
	}
}
