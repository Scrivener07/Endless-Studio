namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableModule : DroppableReferenceTechnology
	{

		private string moduleNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ModuleName
		{
			get
			{
				return this.moduleNameField;
			}
			set
			{
				this.moduleNameField = value;
				this.RaisePropertyChanged("ModuleName");
			}
		}
	}
}
