using ES2.Editor.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(TutorialDefinition))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestDefinition : DatatableElement
	{
		private Tags tagsField;

		private QuestTriggeringContextSolo[] itemsField;

		private RepetitionRules repetitionRulesField;

		private RepetitionRules categoryRepetitionRulesField;

		private RepetitionRules subCategoryRepetitionRulesField;

		private GlobalRepetitionRules globalRepetitionRulesField;

		private QuestGuiElementOverrideDefinition[] guiElementOverridesField;

		private QuestVariablesDefinition varsField;

		private QuestPrerequisitesDefinition[] prerequisitesField;

		private QuestStepDefinition[] stepsField;

		private float triggeringProbabilityField;

		private bool checkRandomField;

		private bool evaluatePrerequisitesBeforeVariablesField;

		private int minimumTurnField;

		private int beginnerMinimumTurnField;

		private bool singleCheckPerTurnField;

		private string categoryField;

		private string subCategoryField;

		private string alternateVersionField;

		private bool isInstantField;

		private bool forcePinField;


		public QuestDefinition()
		{
			this.triggeringProbabilityField = ((float)(1F));
			this.checkRandomField = true;
			this.evaluatePrerequisitesBeforeVariablesField = true;
			this.minimumTurnField = 0;
			this.beginnerMinimumTurnField = 0;
			this.singleCheckPerTurnField = false;
			this.alternateVersionField = "";
			this.isInstantField = false;
			this.forcePinField = false;
		}


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get
			{
				return this.tagsField;
			}
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}

		/// <remarks/>
		[XmlElement("QuestContextMulti", typeof(QuestTriggeringContextMulti), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("QuestContextSolo", typeof(QuestTriggeringContextSolo), Form = XmlSchemaForm.Unqualified)]
		public QuestTriggeringContextSolo[] Items
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
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public RepetitionRules RepetitionRules
		{
			get
			{
				return this.repetitionRulesField;
			}
			set
			{
				this.repetitionRulesField = value;
				this.RaisePropertyChanged("RepetitionRules");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public RepetitionRules CategoryRepetitionRules
		{
			get
			{
				return this.categoryRepetitionRulesField;
			}
			set
			{
				this.categoryRepetitionRulesField = value;
				this.RaisePropertyChanged("CategoryRepetitionRules");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public RepetitionRules SubCategoryRepetitionRules
		{
			get
			{
				return this.subCategoryRepetitionRulesField;
			}
			set
			{
				this.subCategoryRepetitionRulesField = value;
				this.RaisePropertyChanged("SubCategoryRepetitionRules");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public GlobalRepetitionRules GlobalRepetitionRules
		{
			get
			{
				return this.globalRepetitionRulesField;
			}
			set
			{
				this.globalRepetitionRulesField = value;
				this.RaisePropertyChanged("GlobalRepetitionRules");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("GuiElementOverride", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public QuestGuiElementOverrideDefinition[] GuiElementOverrides
		{
			get
			{
				return this.guiElementOverridesField;
			}
			set
			{
				this.guiElementOverridesField = value;
				this.RaisePropertyChanged("GuiElementOverrides");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestVariablesDefinition Vars
		{
			get
			{
				return this.varsField;
			}
			set
			{
				this.varsField = value;
				this.RaisePropertyChanged("Vars");
			}
		}

		/// <remarks/>
		[XmlElement("Prerequisites", Form = XmlSchemaForm.Unqualified)]
		public QuestPrerequisitesDefinition[] Prerequisites
		{
			get
			{
				return this.prerequisitesField;
			}
			set
			{
				this.prerequisitesField = value;
				this.RaisePropertyChanged("Prerequisites");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("Step", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public QuestStepDefinition[] Steps
		{
			get
			{
				return this.stepsField;
			}
			set
			{
				this.stepsField = value;
				this.RaisePropertyChanged("Steps");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "1")]
		public float TriggeringProbability
		{
			get
			{
				return this.triggeringProbabilityField;
			}
			set
			{
				this.triggeringProbabilityField = value;
				this.RaisePropertyChanged("TriggeringProbability");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(true)]
		public bool CheckRandom
		{
			get
			{
				return this.checkRandomField;
			}
			set
			{
				this.checkRandomField = value;
				this.RaisePropertyChanged("CheckRandom");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(true)]
		public bool EvaluatePrerequisitesBeforeVariables
		{
			get
			{
				return this.evaluatePrerequisitesBeforeVariablesField;
			}
			set
			{
				this.evaluatePrerequisitesBeforeVariablesField = value;
				this.RaisePropertyChanged("EvaluatePrerequisitesBeforeVariables");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int MinimumTurn
		{
			get
			{
				return this.minimumTurnField;
			}
			set
			{
				this.minimumTurnField = value;
				this.RaisePropertyChanged("MinimumTurn");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int BeginnerMinimumTurn
		{
			get
			{
				return this.beginnerMinimumTurnField;
			}
			set
			{
				this.beginnerMinimumTurnField = value;
				this.RaisePropertyChanged("BeginnerMinimumTurn");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool SingleCheckPerTurn
		{
			get
			{
				return this.singleCheckPerTurnField;
			}
			set
			{
				this.singleCheckPerTurnField = value;
				this.RaisePropertyChanged("SingleCheckPerTurn");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string SubCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
				this.RaisePropertyChanged("SubCategory");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string AlternateVersion
		{
			get
			{
				return this.alternateVersionField;
			}
			set
			{
				this.alternateVersionField = value;
				this.RaisePropertyChanged("AlternateVersion");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsInstant
		{
			get
			{
				return this.isInstantField;
			}
			set
			{
				this.isInstantField = value;
				this.RaisePropertyChanged("IsInstant");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool ForcePin
		{
			get
			{
				return this.forcePinField;
			}
			set
			{
				this.forcePinField = value;
				this.RaisePropertyChanged("ForcePin");
			}
		}


	}
}
