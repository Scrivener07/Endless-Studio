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
	public class QuestExecutionTreeCondition_CheckSenateComposition : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_NumberOfPoliticsField;

		private QuestInputArgument input_NumberOfSenatorsField;

		private QuestInputArgument input_PoliticsField;

		private QuestInputArgument input_MinimumScoreField;

		private QuestInputArgument input_MaximumScoreField;

		private QuestInputArgument input_NumberOfRepresentativesField;

		private bool invertPoliticsCheckField;

		public QuestExecutionTreeCondition_CheckSenateComposition()
		{
			this.invertPoliticsCheckField = false;
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
		public QuestInputArgument Input_NumberOfPolitics
		{
			get
			{
				return this.input_NumberOfPoliticsField;
			}
			set
			{
				this.input_NumberOfPoliticsField = value;
				this.RaisePropertyChanged("Input_NumberOfPolitics");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NumberOfSenators
		{
			get
			{
				return this.input_NumberOfSenatorsField;
			}
			set
			{
				this.input_NumberOfSenatorsField = value;
				this.RaisePropertyChanged("Input_NumberOfSenators");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Politics
		{
			get
			{
				return this.input_PoliticsField;
			}
			set
			{
				this.input_PoliticsField = value;
				this.RaisePropertyChanged("Input_Politics");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumScore
		{
			get
			{
				return this.input_MinimumScoreField;
			}
			set
			{
				this.input_MinimumScoreField = value;
				this.RaisePropertyChanged("Input_MinimumScore");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumScore
		{
			get
			{
				return this.input_MaximumScoreField;
			}
			set
			{
				this.input_MaximumScoreField = value;
				this.RaisePropertyChanged("Input_MaximumScore");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NumberOfRepresentatives
		{
			get
			{
				return this.input_NumberOfRepresentativesField;
			}
			set
			{
				this.input_NumberOfRepresentativesField = value;
				this.RaisePropertyChanged("Input_NumberOfRepresentatives");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool InvertPoliticsCheck
		{
			get
			{
				return this.invertPoliticsCheckField;
			}
			set
			{
				this.invertPoliticsCheckField = value;
				this.RaisePropertyChanged("InvertPoliticsCheck");
			}
		}
	}

}