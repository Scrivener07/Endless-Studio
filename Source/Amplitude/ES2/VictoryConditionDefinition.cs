namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class VictoryConditionDefinition : DatatableElement
	{

		private EmpirePerformanceTracker[] performanceTrackerField;

		private InterpreterBasedVictoryConditionEvaluatorDefinition soloEvaluatorField;

		private InterpreterBasedVictoryConditionEvaluatorDefinition allianceEvaluatorField;

		private bool activeField;

		private string settingNameField;

		private RankIndicator rankIndicatorField;

		private bool hiddenField;

		public VictoryConditionDefinition()
		{
			this.activeField = true;
			this.settingNameField = "True";
			this.rankIndicatorField = RankIndicator.Progress;
			this.hiddenField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PerformanceTracker", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EmpirePerformanceTracker[] PerformanceTracker
		{
			get
			{
				return this.performanceTrackerField;
			}
			set
			{
				this.performanceTrackerField = value;
				this.RaisePropertyChanged("PerformanceTracker");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InterpreterBasedVictoryConditionEvaluatorDefinition SoloEvaluator
		{
			get
			{
				return this.soloEvaluatorField;
			}
			set
			{
				this.soloEvaluatorField = value;
				this.RaisePropertyChanged("SoloEvaluator");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InterpreterBasedVictoryConditionEvaluatorDefinition AllianceEvaluator
		{
			get
			{
				return this.allianceEvaluatorField;
			}
			set
			{
				this.allianceEvaluatorField = value;
				this.RaisePropertyChanged("AllianceEvaluator");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("True")]
		public string SettingName
		{
			get
			{
				return this.settingNameField;
			}
			set
			{
				this.settingNameField = value;
				this.RaisePropertyChanged("SettingName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(RankIndicator.Progress)]
		public RankIndicator RankIndicator
		{
			get
			{
				return this.rankIndicatorField;
			}
			set
			{
				this.rankIndicatorField = value;
				this.RaisePropertyChanged("RankIndicator");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
				this.RaisePropertyChanged("Hidden");
			}
		}
	}
}
