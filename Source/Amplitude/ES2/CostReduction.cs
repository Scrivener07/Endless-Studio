namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class CostReduction : DatatableElement
	{

		private ReductionPropertyByReductionType[] reductionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Reduction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ReductionPropertyByReductionType[] Reduction
		{
			get
			{
				return this.reductionField;
			}
			set
			{
				this.reductionField = value;
				this.RaisePropertyChanged("Reduction");
			}
		}
	}
}
