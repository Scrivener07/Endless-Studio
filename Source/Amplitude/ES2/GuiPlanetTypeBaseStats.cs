namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiPlanetTypeBaseStats : DatatableElement
	{

		private PlanetStat[] statField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Stat", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStat[] Stat
		{
			get
			{
				return this.statField;
			}
			set
			{
				this.statField = value;
				this.RaisePropertyChanged("Stat");
			}
		}
	}
}
