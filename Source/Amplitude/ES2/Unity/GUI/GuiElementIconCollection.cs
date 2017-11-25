namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GuiElementIconCollection : object, System.ComponentModel.INotifyPropertyChanged
	{

		private IconDefinition[] iconField;

		private string defaultSizeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Icon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public IconDefinition[] Icon
		{
			get
			{
				return this.iconField;
			}
			set
			{
				this.iconField = value;
				this.RaisePropertyChanged("Icon");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DefaultSize
		{
			get
			{
				return this.defaultSizeField;
			}
			set
			{
				this.defaultSizeField = value;
				this.RaisePropertyChanged("DefaultSize");
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
