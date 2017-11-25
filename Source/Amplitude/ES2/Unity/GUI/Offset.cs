namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Offset : object, System.ComponentModel.INotifyPropertyChanged
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
