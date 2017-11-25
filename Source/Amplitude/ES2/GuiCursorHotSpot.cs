namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GuiCursorHotSpot : ValueType
	{

		private int xField;

		private int yField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int X
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
		public int Y
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
