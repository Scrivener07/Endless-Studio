namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class Rank : DatatableElement
	{

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private int levelMinField;

		private int levelMaxField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SimulationDescriptorReference
		{
			get
			{
				return this.simulationDescriptorReferenceField;
			}
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int LevelMin
		{
			get
			{
				return this.levelMinField;
			}
			set
			{
				this.levelMinField = value;
				this.RaisePropertyChanged("LevelMin");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int LevelMax
		{
			get
			{
				return this.levelMaxField;
			}
			set
			{
				this.levelMaxField = value;
				this.RaisePropertyChanged("LevelMax");
			}
		}
	}
}
