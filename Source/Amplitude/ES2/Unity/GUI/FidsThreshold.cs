namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class FidsThreshold : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string nameField;

		private string captionField;

		private float minValueField;

		private float maxValueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Caption
		{
			get
			{
				return this.captionField;
			}
			set
			{
				this.captionField = value;
				this.RaisePropertyChanged("Caption");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float MinValue
		{
			get
			{
				return this.minValueField;
			}
			set
			{
				this.minValueField = value;
				this.RaisePropertyChanged("MinValue");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float MaxValue
		{
			get
			{
				return this.maxValueField;
			}
			set
			{
				this.maxValueField = value;
				this.RaisePropertyChanged("MaxValue");
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
