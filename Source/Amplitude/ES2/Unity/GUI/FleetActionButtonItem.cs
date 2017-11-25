namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class FleetActionButtonItem : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string actionNameField;

		private string buttonTypeField;

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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ButtonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
				this.RaisePropertyChanged("ButtonType");
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
