using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestRewardItemDefinition : QuestRewardDefinition
	{
		private string dropVarField;

		private RewardEvaluationMethod evaluationMethodField;

		private int picksField;

		private bool hiddenField;

		private string previewLocalizationKeyField;

		private string previewDescriptionLocalizationKeyField;

		private string localizationKeyField;

		private string descriptionLocalizationKeyField;

		private string droplistField;


		public QuestRewardItemDefinition()
		{
			this.dropVarField = "";
			this.evaluationMethodField = RewardEvaluationMethod.Static;
			this.picksField = 0;
			this.hiddenField = false;
			this.previewLocalizationKeyField = "";
			this.previewDescriptionLocalizationKeyField = "";
			this.localizationKeyField = "";
			this.descriptionLocalizationKeyField = "";
			this.droplistField = "";
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string DropVar
		{
			get
			{
				return this.dropVarField;
			}
			set
			{
				this.dropVarField = value;
				this.RaisePropertyChanged("DropVar");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(RewardEvaluationMethod.Static)]
		public RewardEvaluationMethod EvaluationMethod
		{
			get
			{
				return this.evaluationMethodField;
			}
			set
			{
				this.evaluationMethodField = value;
				this.RaisePropertyChanged("EvaluationMethod");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Picks
		{
			get
			{
				return this.picksField;
			}
			set
			{
				this.picksField = value;
				this.RaisePropertyChanged("Picks");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
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

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string PreviewLocalizationKey
		{
			get
			{
				return this.previewLocalizationKeyField;
			}
			set
			{
				this.previewLocalizationKeyField = value;
				this.RaisePropertyChanged("PreviewLocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string PreviewDescriptionLocalizationKey
		{
			get
			{
				return this.previewDescriptionLocalizationKeyField;
			}
			set
			{
				this.previewDescriptionLocalizationKeyField = value;
				this.RaisePropertyChanged("PreviewDescriptionLocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string LocalizationKey
		{
			get
			{
				return this.localizationKeyField;
			}
			set
			{
				this.localizationKeyField = value;
				this.RaisePropertyChanged("LocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string DescriptionLocalizationKey
		{
			get
			{
				return this.descriptionLocalizationKeyField;
			}
			set
			{
				this.descriptionLocalizationKeyField = value;
				this.RaisePropertyChanged("DescriptionLocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string Droplist
		{
			get
			{
				return this.droplistField;
			}
			set
			{
				this.droplistField = value;
				this.RaisePropertyChanged("Droplist");
			}
		}


	}
}
