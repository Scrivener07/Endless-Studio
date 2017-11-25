namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ObjectiveGuiElement : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string nameField;

		private bool hideProgressionFeedbackField;

		private QuestProgressionFeedbackType progressionFeedbackField;

		private string valueField;

		public ObjectiveGuiElement()
		{
			this.hideProgressionFeedbackField = false;
			this.progressionFeedbackField = QuestProgressionFeedbackType.Default;
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HideProgressionFeedback
		{
			get
			{
				return this.hideProgressionFeedbackField;
			}
			set
			{
				this.hideProgressionFeedbackField = value;
				this.RaisePropertyChanged("HideProgressionFeedback");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(QuestProgressionFeedbackType.Default)]
		public QuestProgressionFeedbackType ProgressionFeedback
		{
			get
			{
				return this.progressionFeedbackField;
			}
			set
			{
				this.progressionFeedbackField = value;
				this.RaisePropertyChanged("ProgressionFeedback");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
