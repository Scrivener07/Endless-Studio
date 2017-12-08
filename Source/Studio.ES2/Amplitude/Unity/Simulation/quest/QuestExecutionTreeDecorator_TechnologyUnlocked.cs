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
	public class QuestExecutionTreeDecorator_TechnologyUnlocked : QuestExecutionTreeDecorator_EmpireEventOfEventTechnologyUnlocked
	{

		private QuestInputArgument input_TechnologyNameField;

		private QuestInputArgument input_TechnologyCategoryField;

		private QuestInputArgument input_TechnologySubCategoryField;

		private QuestInputArgument input_TechnologyStageField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TechnologyName
		{
			get
			{
				return this.input_TechnologyNameField;
			}
			set
			{
				this.input_TechnologyNameField = value;
				this.RaisePropertyChanged("Input_TechnologyName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TechnologyCategory
		{
			get
			{
				return this.input_TechnologyCategoryField;
			}
			set
			{
				this.input_TechnologyCategoryField = value;
				this.RaisePropertyChanged("Input_TechnologyCategory");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TechnologySubCategory
		{
			get
			{
				return this.input_TechnologySubCategoryField;
			}
			set
			{
				this.input_TechnologySubCategoryField = value;
				this.RaisePropertyChanged("Input_TechnologySubCategory");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TechnologyStage
		{
			get
			{
				return this.input_TechnologyStageField;
			}
			set
			{
				this.input_TechnologyStageField = value;
				this.RaisePropertyChanged("Input_TechnologyStage");
			}
		}
	}

}