namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionPatternDefinition_Four))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionPatternDefinition_Eight))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SectionPatternDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SectionDefinition coreSectionField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SectionDefinition CoreSection
		{
			get
			{
				return this.coreSectionField;
			}
			set
			{
				this.coreSectionField = value;
				this.RaisePropertyChanged("CoreSection");
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
