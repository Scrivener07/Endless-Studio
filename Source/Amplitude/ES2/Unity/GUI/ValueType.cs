namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MovieDefinition))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(XmlColor))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(IconDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ValueType : object, System.ComponentModel.INotifyPropertyChanged
	{

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
