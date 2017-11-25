namespace Amplitude.ES2
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SupportPrerequisite : Prerequisite
	{

		private string politicsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Politics
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
	}
}
