namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleEffect_EmpireReward_Resource : BattleEffect
	{

		private string resourceNameField;

		private string interpreterFormulaField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ResourceName
		{
			get
			{
				return this.resourceNameField;
			}
			set
			{
				this.resourceNameField = value;
				this.RaisePropertyChanged("ResourceName");
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
