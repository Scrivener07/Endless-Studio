namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Entry : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string tagField;

		private float weightField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Tag
		{
			get
			{
				return this.tagField;
			}
			set
			{
				this.tagField = value;
				this.RaisePropertyChanged("Tag");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
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
