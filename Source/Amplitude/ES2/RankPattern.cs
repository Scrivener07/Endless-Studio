namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class RankPattern : DatatableElement
	{

		private Prerequisite[] itemsField;

		private XmlNamedReference[] rankReferenceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RankReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] RankReference
		{
			get
			{
				return this.rankReferenceField;
			}
			set
			{
				this.rankReferenceField = value;
				this.RaisePropertyChanged("RankReference");
			}
		}
	}
}
