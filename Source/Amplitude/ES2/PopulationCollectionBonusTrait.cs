namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PopulationCollectionBonusTrait : PopulationTrait
	{

		private Item[] collectionBonusField;

		private string customEquivalentField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CollectionBonus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Item[] CollectionBonus
		{
			get
			{
				return this.collectionBonusField;
			}
			set
			{
				this.collectionBonusField = value;
				this.RaisePropertyChanged("CollectionBonus");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomEquivalent
		{
			get
			{
				return this.customEquivalentField;
			}
			set
			{
				this.customEquivalentField = value;
				this.RaisePropertyChanged("CustomEquivalent");
			}
		}
	}
}
