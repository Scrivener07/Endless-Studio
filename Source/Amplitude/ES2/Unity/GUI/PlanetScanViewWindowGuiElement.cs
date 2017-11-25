namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlanetScanViewWindowGuiElement : ScanViewWindowGuiElement
	{

		private PlanetStatsCategory[] categoriesOnTheLeftField;

		private PlanetStatsCategory[] categoriesOnTheRightField;

		private PlanetStatsCategory[] categoryField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatsCategory[] CategoriesOnTheLeft
		{
			get
			{
				return this.categoriesOnTheLeftField;
			}
			set
			{
				this.categoriesOnTheLeftField = value;
				this.RaisePropertyChanged("CategoriesOnTheLeft");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatsCategory[] CategoriesOnTheRight
		{
			get
			{
				return this.categoriesOnTheRightField;
			}
			set
			{
				this.categoriesOnTheRightField = value;
				this.RaisePropertyChanged("CategoriesOnTheRight");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Category", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatsCategory[] Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}
	}
}
