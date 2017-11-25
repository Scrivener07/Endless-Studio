namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GeneratorInfo : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] planetFilterMustField;

		private string[] planetFilterAnyField;

		private string[] planetFilterNotField;

		private string[] planetTagsReplaceField;

		private bool excludeFromRandomPlacementField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterMust", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterMust
		{
			get
			{
				return this.planetFilterMustField;
			}
			set
			{
				this.planetFilterMustField = value;
				this.RaisePropertyChanged("PlanetFilterMust");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterAny", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterAny
		{
			get
			{
				return this.planetFilterAnyField;
			}
			set
			{
				this.planetFilterAnyField = value;
				this.RaisePropertyChanged("PlanetFilterAny");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterNot", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterNot
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
		[System.Xml.Serialization.XmlElementAttribute("PlanetTagsReplace", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetTagsReplace
		{
			get
			{
				return this.planetTagsReplaceField;
			}
			set
			{
				this.planetTagsReplaceField = value;
				this.RaisePropertyChanged("PlanetTagsReplace");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
