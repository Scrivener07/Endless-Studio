namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SoundDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string eventNameField;

		private bool isMusicField;

		private string typeField;

		public SoundDefinition()
		{
			this.isMusicField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EventName
		{
			get
			{
				return this.eventNameField;
			}
			set
			{
				this.eventNameField = value;
				this.RaisePropertyChanged("EventName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsMusic
		{
			get
			{
				return this.isMusicField;
			}
			set
			{
				this.isMusicField = value;
				this.RaisePropertyChanged("IsMusic");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
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
