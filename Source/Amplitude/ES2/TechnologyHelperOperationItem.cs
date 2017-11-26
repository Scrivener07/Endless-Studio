namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyHelperOperation))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyHelperOperationInt))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyHelperOperationValue))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyHelperOperationRefinedProperty))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class TechnologyHelperOperationItem : object, System.ComponentModel.INotifyPropertyChanged
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
