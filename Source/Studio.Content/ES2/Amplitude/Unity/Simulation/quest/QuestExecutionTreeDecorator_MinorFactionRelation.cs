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
	public class QuestExecutionTreeDecorator_MinorFactionRelation : QuestExecutionTreeDecoratorOfEventBeginTurn
	{

		private QuestInputArgument input_PlayerEmpireField;

		private QuestInputArgument input_MinorEmpireField;

		private QuestInputArgument input_MaximumRelationPointsField;

		private QuestInputArgument input_MinimumRelationPointsField;

		private QuestInputArgument input_RelationStateField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PlayerEmpire
		{
			get
			{
				return this.input_PlayerEmpireField;
			}
			set
			{
				this.input_PlayerEmpireField = value;
				this.RaisePropertyChanged("Input_PlayerEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinorEmpire
		{
			get
			{
				return this.input_MinorEmpireField;
			}
			set
			{
				this.input_MinorEmpireField = value;
				this.RaisePropertyChanged("Input_MinorEmpire");
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
		public QuestInputArgument Input_RelationState
		{
			get
			{
				return this.input_RelationStateField;
			}
			set
			{
				this.input_RelationStateField = value;
				this.RaisePropertyChanged("Input_RelationState");
			}
		}
	}

}