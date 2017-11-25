namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Palette))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class XmlColorPalette : object, System.ComponentModel.INotifyPropertyChanged
	{

		private XmlColorReference[] colorReferenceField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ColorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlColorReference[] ColorReference
		{
			get
			{
				return this.colorReferenceField;
			}
			set
			{
				this.colorReferenceField = value;
				this.RaisePropertyChanged("ColorReference");
			}
		}

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
