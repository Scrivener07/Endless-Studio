namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MinorFaction : Faction
	{

		private XmlNamedReference personalityField;

		private XmlNamedReference politicsField;

		private ColonizablePlanetType[] colonizablePlanetField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Personality
		{
			get
			{
				return this.personalityField;
			}
			set
			{
				this.personalityField = value;
				this.RaisePropertyChanged("Personality");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Politics
		{
			get
			{
				return this.politicsField;
			}
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("ColonizablePlanet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ColonizablePlanetType[] ColonizablePlanet
		{
			get
			{
				return this.colonizablePlanetField;
			}
			set
			{
				this.colonizablePlanetField = value;
				this.RaisePropertyChanged("ColonizablePlanet");
			}
		}
	}
}
