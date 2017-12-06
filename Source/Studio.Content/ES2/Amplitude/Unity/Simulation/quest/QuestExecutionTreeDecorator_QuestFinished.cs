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
	public class QuestExecutionTreeDecorator_QuestFinished : QuestExecutionTreeDecorator_EmpireEventOfEventOnQuestCompleted
	{

		private QuestInputArgument input_QuestNameField;

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_SubCategoryField;

		private QuestCompletionStateCondition requiredStateField;

		public QuestExecutionTreeDecorator_QuestFinished()
		{
			this.requiredStateField = QuestCompletionStateCondition.Any;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_QuestName
		{
			get
			{
				return this.input_QuestNameField;
			}
			set
			{
				this.input_QuestNameField = value;
				this.RaisePropertyChanged("Input_QuestName");
			}
		}

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
		public QuestInputArgument Input_SubCategory
		{
			get
			{
				return this.input_SubCategoryField;
			}
			set
			{
				this.input_SubCategoryField = value;
				this.RaisePropertyChanged("Input_SubCategory");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(QuestCompletionStateCondition.Any)]
		public QuestCompletionStateCondition RequiredState
		{
			get
			{
				return this.requiredStateField;
			}
			set
			{
				this.requiredStateField = value;
				this.RaisePropertyChanged("RequiredState");
			}
		}
	}

}