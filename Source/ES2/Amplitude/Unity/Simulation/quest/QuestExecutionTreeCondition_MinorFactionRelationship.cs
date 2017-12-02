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
	public class QuestExecutionTreeCondition_MinorFactionRelationship : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_MajorEmpireField;

		private QuestInputArgument input_NumberOfMinorFactionsField;

		private QuestInputArgument[] input_DiplomaticRelationStateField;

		private QuestInputArgument input_MinimumRelationPointsField;

		private QuestInputArgument input_MaximumRelationPointsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MajorEmpire
		{
			get
			{
				return this.input_MajorEmpireField;
			}
			set
			{
				this.input_MajorEmpireField = value;
				this.RaisePropertyChanged("Input_MajorEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NumberOfMinorFactions
		{
			get
			{
				return this.input_NumberOfMinorFactionsField;
			}
			set
			{
				this.input_NumberOfMinorFactionsField = value;
				this.RaisePropertyChanged("Input_NumberOfMinorFactions");
			}
		}

		/// <remarks/>
		[XmlElement("Input_DiplomaticRelationState", Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument[] Input_DiplomaticRelationState
		{
			get
			{
				return this.input_DiplomaticRelationStateField;
			}
			set
			{
				this.input_DiplomaticRelationStateField = value;
				this.RaisePropertyChanged("Input_DiplomaticRelationState");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumRelationPoints
		{
			get
			{
				return this.input_MinimumRelationPointsField;
			}
			set
			{
				this.input_MinimumRelationPointsField = value;
				this.RaisePropertyChanged("Input_MinimumRelationPoints");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumRelationPoints
		{
			get
			{
				return this.input_MaximumRelationPointsField;
			}
			set
			{
				this.input_MaximumRelationPointsField = value;
				this.RaisePropertyChanged("Input_MaximumRelationPoints");
			}
		}
	}

}