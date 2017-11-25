namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class AffinityGuiElement : ExtendedGuiElement
	{

		private string modelPathField;

		private int preloadCountField;

		public AffinityGuiElement()
		{
			this.preloadCountField = 0;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ModelPath
		{
			get
			{
				return this.modelPathField;
			}
			set
			{
				this.modelPathField = value;
				this.RaisePropertyChanged("ModelPath");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int PreloadCount
		{
			get
			{
				return this.preloadCountField;
			}
			set
			{
				this.preloadCountField = value;
				this.RaisePropertyChanged("PreloadCount");
			}
		}
	}
}
