namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TechnologyGuiElement2 : GuiElement
	{

		private float xField;

		private float yField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float X
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
				this.RaisePropertyChanged("X");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
				this.RaisePropertyChanged("Y");
			}
		}
	}
}
