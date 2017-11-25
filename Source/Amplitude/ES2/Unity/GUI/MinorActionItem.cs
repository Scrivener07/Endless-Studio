namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class MinorActionItem : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string actionNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ActionName
		{
			get
			{
				return this.actionNameField;
			}
			set
			{
				this.actionNameField = value;
				this.RaisePropertyChanged("ActionName");
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
