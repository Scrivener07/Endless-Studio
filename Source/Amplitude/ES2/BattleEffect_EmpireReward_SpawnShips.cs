namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class BattleEffect_EmpireReward_SpawnShips : BattleEffect
	{

		private string shipDesignNameField;

		private string interpreterFormulaField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShipDesignName
		{
			get
			{
				return this.shipDesignNameField;
			}
			set
			{
				this.shipDesignNameField = value;
				this.RaisePropertyChanged("ShipDesignName");
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
