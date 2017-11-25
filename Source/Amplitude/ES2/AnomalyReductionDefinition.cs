namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class AnomalyReductionDefinition : ConstructibleElement
	{

		private XmlNamedReference baseAnomalyField;

		private XmlNamedReference resultAnomalyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference BaseAnomaly
		{
			get
			{
				return this.baseAnomalyField;
			}
			set
			{
				this.baseAnomalyField = value;
				this.RaisePropertyChanged("BaseAnomaly");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference ResultAnomaly
		{
			get
			{
				return this.resultAnomalyField;
			}
			set
			{
				this.resultAnomalyField = value;
				this.RaisePropertyChanged("ResultAnomaly");
			}
		}
	}
}
