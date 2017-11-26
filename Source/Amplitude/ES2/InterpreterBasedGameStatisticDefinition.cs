namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class InterpreterBasedGameStatisticDefinition : GameStatisticDefinition
	{

		private string expressionField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Expression
		{
			get
			{
				return this.expressionField;
			}
			set
			{
				this.expressionField = value;
				this.RaisePropertyChanged("Expression");
			}
		}
	}
}
