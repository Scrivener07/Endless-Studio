namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SerializableDirection : object, System.ComponentModel.INotifyPropertyChanged
	{

		private float xField;

		private float zField;


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

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
