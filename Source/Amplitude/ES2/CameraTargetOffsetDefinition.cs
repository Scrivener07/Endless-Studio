namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraTargetOffsetDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private CameraTargetFilterDefinition targetFilterField;

		private SerializableVector3 targetOffsetField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetFilterDefinition TargetFilter
		{
			get
			{
				return this.targetFilterField;
			}
			set
			{
				this.targetFilterField = value;
				this.RaisePropertyChanged("TargetFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 TargetOffset
		{
			get
			{
				return this.targetOffsetField;
			}
			set
			{
				this.targetOffsetField = value;
				this.RaisePropertyChanged("TargetOffset");
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
