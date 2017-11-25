namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableBlueprint : DroppableReferenceTechnology
	{

		private string constructibleNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ConstructibleName
		{
			get
			{
				return this.constructibleNameField;
			}
			set
			{
				this.constructibleNameField = value;
				this.RaisePropertyChanged("ConstructibleName");
			}
		}
	}
}
