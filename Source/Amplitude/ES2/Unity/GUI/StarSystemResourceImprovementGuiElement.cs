namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class StarSystemResourceImprovementGuiElement : ExtendedGuiElement
	{

		private string resourcesDescriptionField;

		private bool hasVariablePopulationSymbolField;

		public StarSystemResourceImprovementGuiElement()
		{
			this.hasVariablePopulationSymbolField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ResourcesDescription
		{
			get
			{
				return this.resourcesDescriptionField;
			}
			set
			{
				this.resourcesDescriptionField = value;
				this.RaisePropertyChanged("ResourcesDescription");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HasVariablePopulationSymbol
		{
			get
			{
				return this.hasVariablePopulationSymbolField;
			}
			set
			{
				this.hasVariablePopulationSymbolField = value;
				this.RaisePropertyChanged("HasVariablePopulationSymbol");
			}
		}
	}
}
