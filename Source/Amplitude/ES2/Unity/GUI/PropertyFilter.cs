namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class PropertyFilter : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string propertyNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PropertyName
		{
			get
			{
				return this.propertyNameField;
			}
			set
			{
				this.propertyNameField = value;
				this.RaisePropertyChanged("PropertyName");
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
