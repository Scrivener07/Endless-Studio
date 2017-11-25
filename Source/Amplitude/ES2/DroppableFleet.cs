namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableFleet : Droppable
	{

		private string heroDefinitionField;

		private string[] shipDesignField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string HeroDefinition
		{
			get
			{
				return this.heroDefinitionField;
			}
			set
			{
				this.heroDefinitionField = value;
				this.RaisePropertyChanged("HeroDefinition");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ShipDesign", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] ShipDesign
		{
			get
			{
				return this.shipDesignField;
			}
			set
			{
				this.shipDesignField = value;
				this.RaisePropertyChanged("ShipDesign");
			}
		}
	}
}
