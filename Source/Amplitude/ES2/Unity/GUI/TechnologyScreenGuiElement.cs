namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TechnologyScreenGuiElement : WindowGuiElement
	{

		private TechnologyQuadrantGuiElement[] technologyQuadrantGuiElementField;

		private int maxTechnologyStagesField;

		private float minQuadrantRadiusField;

		private float maxQuadrantRadiusField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TechnologyQuadrantGuiElement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TechnologyQuadrantGuiElement[] TechnologyQuadrantGuiElement
		{
			get
			{
				return this.technologyQuadrantGuiElementField;
			}
			set
			{
				this.technologyQuadrantGuiElementField = value;
				this.RaisePropertyChanged("TechnologyQuadrantGuiElement");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int MaxTechnologyStages
		{
			get
			{
				return this.maxTechnologyStagesField;
			}
			set
			{
				this.maxTechnologyStagesField = value;
				this.RaisePropertyChanged("MaxTechnologyStages");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float MinQuadrantRadius
		{
			get
			{
				return this.minQuadrantRadiusField;
			}
			set
			{
				this.minQuadrantRadiusField = value;
				this.RaisePropertyChanged("MinQuadrantRadius");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float MaxQuadrantRadius
		{
			get
			{
				return this.maxQuadrantRadiusField;
			}
			set
			{
				this.maxQuadrantRadiusField = value;
				this.RaisePropertyChanged("MaxQuadrantRadius");
			}
		}
	}
}
