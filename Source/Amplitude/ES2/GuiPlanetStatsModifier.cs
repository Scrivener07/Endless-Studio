namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiPlanetStatsModifier : DatatableElement
	{

		private PlanetStatModifier[] statModifierField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StatModifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PlanetStatModifier[] StatModifier
		{
			get
			{
				return this.statModifierField;
			}
			set
			{
				this.statModifierField = value;
				this.RaisePropertyChanged("StatModifier");
			}
		}
	}
}
