namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class LoadingWindowGuiElement : WindowGuiElement
	{

		private string[] texturePathField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TexturePath", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] TexturePath
		{
			get
			{
				return this.texturePathField;
			}
			set
			{
				this.texturePathField = value;
				this.RaisePropertyChanged("TexturePath");
			}
		}
	}
}
