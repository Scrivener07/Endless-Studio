using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeCondition_FleetHasHero : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_FleetField;

		private QuestInputArgument input_FleetGUIDField;

		private QuestInputArgument input_HeroGUIDField;

		private QuestInputArgument input_HeroField;

		private QuestInputArgument input_HeroDefinitionNameField;

		private QuestInputArgument input_HeroAffinityField;

		private QuestInputArgument input_HeroClassField;

		private QuestInputArgument input_HeroPoliticsField;

		private QuestInputArgument input_HeroMinLevelField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleet
		{
			get
			{
				return this.input_FleetField;
			}
			set
			{
				this.input_FleetField = value;
				this.RaisePropertyChanged("Input_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_FleetGUID
		{
			get
			{
				return this.input_FleetGUIDField;
			}
			set
			{
				this.input_FleetGUIDField = value;
				this.RaisePropertyChanged("Input_FleetGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroGUID
		{
			get
			{
				return this.input_HeroGUIDField;
			}
			set
			{
				this.input_HeroGUIDField = value;
				this.RaisePropertyChanged("Input_HeroGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Hero
		{
			get
			{
				return this.input_HeroField;
			}
			set
			{
				this.input_HeroField = value;
				this.RaisePropertyChanged("Input_Hero");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroDefinitionName
		{
			get
			{
				return this.input_HeroDefinitionNameField;
			}
			set
			{
				this.input_HeroDefinitionNameField = value;
				this.RaisePropertyChanged("Input_HeroDefinitionName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroAffinity
		{
			get
			{
				return this.input_HeroAffinityField;
			}
			set
			{
				this.input_HeroAffinityField = value;
				this.RaisePropertyChanged("Input_HeroAffinity");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroClass
		{
			get
			{
				return this.input_HeroClassField;
			}
			set
			{
				this.input_HeroClassField = value;
				this.RaisePropertyChanged("Input_HeroClass");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroPolitics
		{
			get
			{
				return this.input_HeroPoliticsField;
			}
			set
			{
				this.input_HeroPoliticsField = value;
				this.RaisePropertyChanged("Input_HeroPolitics");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroMinLevel
		{
			get
			{
				return this.input_HeroMinLevelField;
			}
			set
			{
				this.input_HeroMinLevelField = value;
				this.RaisePropertyChanged("Input_HeroMinLevel");
			}
		}
	}

}