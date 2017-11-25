namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DummyGeneratorInfo : ValueType
	{

		private PlanetFilterNot[] planetFilterNotField;

		private bool excludeFromRandomPlacementField;

		public DummyGeneratorInfo()
		{
			this.excludeFromRandomPlacementField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterNot", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetFilterNot[] PlanetFilterNot
		{
			get
			{
				return this.planetFilterNotField;
			}
			set
			{
				this.planetFilterNotField = value;
				this.RaisePropertyChanged("PlanetFilterNot");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ExcludeFromRandomPlacement
		{
			get
			{
				return this.excludeFromRandomPlacementField;
			}
			set
			{
				this.excludeFromRandomPlacementField = value;
				this.RaisePropertyChanged("ExcludeFromRandomPlacement");
			}
		}
	}
}
