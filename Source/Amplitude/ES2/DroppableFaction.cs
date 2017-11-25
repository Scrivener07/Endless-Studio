namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableFaction : Droppable
	{

		private string factionNameField;

		private string titleField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string FactionName
		{
			get
			{
				return this.factionNameField;
			}
			set
			{
				this.factionNameField = value;
				this.RaisePropertyChanged("FactionName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}
	}
}
