namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class TechnologyHelperOperationRefinedProperty : TechnologyHelperOperationItem
	{

		private PropertyType propertyField;

		private int resourceIndexField;

		public TechnologyHelperOperationRefinedProperty()
		{
			this.resourceIndexField = 0;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public PropertyType Property
		{
			get
			{
				return this.propertyField;
			}
			set
			{
				this.propertyField = value;
				this.RaisePropertyChanged("Property");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int ResourceIndex
		{
			get
			{
				return this.resourceIndexField;
			}
			set
			{
				this.resourceIndexField = value;
				this.RaisePropertyChanged("ResourceIndex");
			}
		}
	}
}
