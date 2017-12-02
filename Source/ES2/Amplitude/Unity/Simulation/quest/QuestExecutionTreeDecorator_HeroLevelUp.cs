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
	public class QuestExecutionTreeDecorator_HeroLevelUp : QuestExecutionTreeDecorator_EmpireEventOfEventHeroLevelup
	{

		private QuestInputArgument input_HeroField;

		private QuestInputArgument input_HeroClassField;

		private QuestInputArgument input_MinimumLevelField;

		private QuestOutputArgument output_HeroField;

		private QuestOutputArgument output_HeroGUIDField;

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
		public QuestInputArgument Input_MinimumLevel
		{
			get
			{
				return this.input_MinimumLevelField;
			}
			set
			{
				this.input_MinimumLevelField = value;
				this.RaisePropertyChanged("Input_MinimumLevel");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Hero
		{
			get
			{
				return this.output_HeroField;
			}
			set
			{
				this.output_HeroField = value;
				this.RaisePropertyChanged("Output_Hero");
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