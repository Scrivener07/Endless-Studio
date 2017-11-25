namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Hero))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Improvement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Law))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Ship))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_TimeBubble))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BailiffSimulationAuctionOfAuctionItem_GameEntity : BailiffAuctionOfAuctionItem_GameEntity
	{

		private string scoringFunctionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ScoringFunction
		{
			get
			{
				return this.scoringFunctionField;
			}
			set
			{
				this.scoringFunctionField = value;
				this.RaisePropertyChanged("ScoringFunction");
			}
		}
	}
}
