namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(InterpreterBasedVictoryConditionEvaluatorDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class VictoryConditionEvaluatorDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private VictoryConditionAlert[] alertField;


		[System.Xml.Serialization.XmlElementAttribute("Alert", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public VictoryConditionAlert[] Alert
		{
			get
			{
				return this.alertField;
			}
			set
			{
				this.alertField = value;
				this.RaisePropertyChanged("Alert");
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
