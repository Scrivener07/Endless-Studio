namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class RestrictionSet : object, System.ComponentModel.INotifyPropertyChanged
	{

		private RestrictionValue[] ifField;

		private RestrictionValue[] disableField;


		[System.Xml.Serialization.XmlElementAttribute("If", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RestrictionValue[] If
		{
			get
			{
				return this.ifField;
			}
			set
			{
				this.ifField = value;
				this.RaisePropertyChanged("If");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Disable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RestrictionValue[] Disable
		{
			get
			{
				return this.disableField;
			}
			set
			{
				this.disableField = value;
				this.RaisePropertyChanged("Disable");
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
