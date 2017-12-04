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
	public class QuestExecutionTreeAction_SetMinorRelationPoints : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinorEmpireField;

		private QuestInputArgument input_RelationPointsField;

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
		public QuestInputArgument Input_RelationPoints
		{
			get
			{
				return this.input_RelationPointsField;
			}
			set
			{
				this.input_RelationPointsField = value;
				this.RaisePropertyChanged("Input_RelationPoints");
			}
		}
	}

}