namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MinorFactionPersonalityDefinition : DatatableElement
	{

		private XmlNamedReference majorTraitField;

		private RandomTrait[] minorTraitField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference MajorTrait
		{
			get
			{
				return this.majorTraitField;
			}
			set
			{
				this.majorTraitField = value;
				this.RaisePropertyChanged("MajorTrait");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MinorTrait", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RandomTrait[] MinorTrait
		{
			get
			{
				return this.minorTraitField;
			}
			set
			{
				this.minorTraitField = value;
				this.RaisePropertyChanged("MinorTrait");
			}
		}
	}
}
