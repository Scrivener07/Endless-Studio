namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ObjectiveSetGuiElement : GuiElement
	{

		private string tooltipDescriptionField;

		private OutcomeGuiElement[] outcomeCompletedField;

		private OutcomeGuiElement[] outcomeFailedField;

		private ObjectiveGuiElement[] objectiveField;

		private string politicsField;

		private string onlyChoiceTooltipKeyField;

		private string teamField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TooltipDescription
		{
			get
			{
				return this.tooltipDescriptionField;
			}
			set
			{
				this.tooltipDescriptionField = value;
				this.RaisePropertyChanged("TooltipDescription");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OutcomeCompleted", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutcomeGuiElement[] OutcomeCompleted
		{
			get
			{
				return this.outcomeCompletedField;
			}
			set
			{
				this.outcomeCompletedField = value;
				this.RaisePropertyChanged("OutcomeCompleted");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OutcomeFailed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutcomeGuiElement[] OutcomeFailed
		{
			get
			{
				return this.outcomeFailedField;
			}
			set
			{
				this.outcomeFailedField = value;
				this.RaisePropertyChanged("OutcomeFailed");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Objective", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ObjectiveGuiElement[] Objective
		{
			get
			{
				return this.objectiveField;
			}
			set
			{
				this.objectiveField = value;
				this.RaisePropertyChanged("Objective");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Politics
		{
			get
			{
				return this.politicsField;
			}
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OnlyChoiceTooltipKey
		{
			get
			{
				return this.onlyChoiceTooltipKeyField;
			}
			set
			{
				this.onlyChoiceTooltipKeyField = value;
				this.RaisePropertyChanged("OnlyChoiceTooltipKey");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Team
		{
			get
			{
				return this.teamField;
			}
			set
			{
				this.teamField = value;
				this.RaisePropertyChanged("Team");
			}
		}
	}
}
