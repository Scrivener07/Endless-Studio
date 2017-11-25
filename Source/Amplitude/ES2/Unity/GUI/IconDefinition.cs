namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class IconDefinition : ValueType
	{

		private string pathField;

		private string sizeField;

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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
				this.RaisePropertyChanged("Size");
			}
		}
	}
}
