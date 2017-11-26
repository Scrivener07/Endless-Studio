namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class TechnologyHelperOperationValue : TechnologyHelperOperationItem
	{

		private SourceType sourceField;

		private string pathField;

		private string propertyNameField;

		private float multiplierField;

		public TechnologyHelperOperationValue()
		{
			this.multiplierField = ((float)(1F));
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public SourceType Source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				this.RaisePropertyChanged("Source");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
				this.RaisePropertyChanged("Path");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PropertyName
		{
			get
			{
				return this.propertyNameField;
			}
			set
			{
				this.propertyNameField = value;
				this.RaisePropertyChanged("PropertyName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float Multiplier
		{
			get
			{
				return this.multiplierField;
			}
			set
			{
				this.multiplierField = value;
				this.RaisePropertyChanged("Multiplier");
			}
		}
	}
}
