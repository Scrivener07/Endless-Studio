namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class TutorialPage : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Prerequisite[] itemsField;

		private string titleField;

		private string descriptionField;

		private Highlight[] highlightField;

		private Disabler[] disablerField;

		private bool highlightLanesField;

		public TutorialPage()
		{
			this.highlightLanesField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GameSettingPrerequisite", typeof(GameSettingPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PathPrerequisite", typeof(PathPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("QuestStatePrerequisite", typeof(QuestStatePrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TutorialLevelPrerequisite", typeof(TutorialLevelPrerequisite), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Highlight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Highlight[] Highlight
		{
			get
			{
				return this.highlightField;
			}
			set
			{
				this.highlightField = value;
				this.RaisePropertyChanged("Highlight");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Disabler", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Disabler[] Disabler
		{
			get
			{
				return this.disablerField;
			}
			set
			{
				this.disablerField = value;
				this.RaisePropertyChanged("Disabler");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HighlightLanes
		{
			get
			{
				return this.highlightLanesField;
			}
			set
			{
				this.highlightLanesField = value;
				this.RaisePropertyChanged("HighlightLanes");
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
