namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ItemDefinition : DatatableElement
	{

		private KeyValuePair[] keyValuePairField;

		private bool isRecommendedField;

		public ItemDefinition()
		{
			this.isRecommendedField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute("KeyValuePair", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public KeyValuePair[] KeyValuePair
		{
			get
			{
				return this.keyValuePairField;
			}
			set
			{
				this.keyValuePairField = value;
				this.RaisePropertyChanged("KeyValuePair");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsRecommended
		{
			get
			{
				return this.isRecommendedField;
			}
			set
			{
				this.isRecommendedField = value;
				this.RaisePropertyChanged("IsRecommended");
			}
		}
	}
}
