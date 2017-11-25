namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class XmlColor : ValueType
	{

		private byte alphaField;

		private byte blueField;

		private byte greenField;

		private byte redField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte Alpha
		{
			get
			{
				return this.alphaField;
			}
			set
			{
				this.alphaField = value;
				this.RaisePropertyChanged("Alpha");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte Blue
		{
			get
			{
				return this.blueField;
			}
			set
			{
				this.blueField = value;
				this.RaisePropertyChanged("Blue");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte Green
		{
			get
			{
				return this.greenField;
			}
			set
			{
				this.greenField = value;
				this.RaisePropertyChanged("Green");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte Red
		{
			get
			{
				return this.redField;
			}
			set
			{
				this.redField = value;
				this.RaisePropertyChanged("Red");
			}
		}
	}
}
