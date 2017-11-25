namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GuiCursorImage : ValueType
	{

		private string pathField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
				this.RaisePropertyChanged("Path");
			}
		}
	}
}
