namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class AnimationCurve : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Keyframe[] keysField;

		private WrapMode preWrapModeField;

		private WrapMode postWrapModeField;


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public Keyframe[] keys
		{
			get
			{
				return this.keysField;
			}
			set
			{
				this.keysField = value;
				this.RaisePropertyChanged("keys");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public WrapMode preWrapMode
		{
			get
			{
				return this.preWrapModeField;
			}
			set
			{
				this.preWrapModeField = value;
				this.RaisePropertyChanged("preWrapMode");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public WrapMode postWrapMode
		{
			get
			{
				return this.postWrapModeField;
			}
			set
			{
				this.postWrapModeField = value;
				this.RaisePropertyChanged("postWrapMode");
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
