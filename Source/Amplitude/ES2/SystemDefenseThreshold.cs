namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class SystemDefenseThreshold : DatatableElement
	{

		private int valueMinField;

		private int valueMaxField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int ValueMin
		{
			get
			{
				return this.valueMinField;
			}
			set
			{
				this.valueMinField = value;
				this.RaisePropertyChanged("ValueMin");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int ValueMax
		{
			get
			{
				return this.valueMaxField;
			}
			set
			{
				this.valueMaxField = value;
				this.RaisePropertyChanged("ValueMax");
			}
		}
	}
}
