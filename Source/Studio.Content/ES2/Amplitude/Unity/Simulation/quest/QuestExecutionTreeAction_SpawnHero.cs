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
	public class QuestExecutionTreeAction_SpawnHero : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_HeroDefinitionField;

		private QuestInputArgument input_HeroLevelField;

		private QuestOutputArgument output_HeroGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empire
		{
			get
			{
				return this.input_EmpireField;
			}
			set
			{
				this.input_EmpireField = value;
				this.RaisePropertyChanged("Input_Empire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroDefinition
		{
			get
			{
				return this.input_HeroDefinitionField;
			}
			set
			{
				this.input_HeroDefinitionField = value;
				this.RaisePropertyChanged("Input_HeroDefinition");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroLevel
		{
			get
			{
				return this.input_HeroLevelField;
			}
			set
			{
				this.input_HeroLevelField = value;
				this.RaisePropertyChanged("Input_HeroLevel");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_HeroGUID
		{
			get
			{
				return this.output_HeroGUIDField;
			}
			set
			{
				this.output_HeroGUIDField = value;
				this.RaisePropertyChanged("Output_HeroGUID");
			}
		}
	}

}