namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SerializableQuaternion : ValueType
	{

		private float xField;

		private float yField;

		private float zField;

		private float wField;


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


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Z
		{
			get
			{
				return this.zField;
			}
			set
			{
				this.zField = value;
				this.RaisePropertyChanged("Z");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float W
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
				this.RaisePropertyChanged("W");
			}
		}
	}
}
