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
	public class QuestExecutionTreeDecorator_TimeBubbleCreated : QuestExecutionTreeDecorator_EmpireEventOfEventTimeBubbleCreated
	{

		private QuestInputArgument input_TargetEmpireField;

		private QuestInputArgument input_NodeField;

		private QuestInputArgument input_ColonizedStarSystemField;

		private QuestInputArgument input_DefinitionNameField;

		private QuestOutputArgument output_NodeField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TargetEmpire
		{
			get
			{
				return this.input_TargetEmpireField;
			}
			set
			{
				this.input_TargetEmpireField = value;
				this.RaisePropertyChanged("Input_TargetEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Node
		{
			get
			{
				return this.input_NodeField;
			}
			set
			{
				this.input_NodeField = value;
				this.RaisePropertyChanged("Input_Node");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ColonizedStarSystem
		{
			get
			{
				return this.input_ColonizedStarSystemField;
			}
			set
			{
				this.input_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Input_ColonizedStarSystem");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DefinitionName
		{
			get
			{
				return this.input_DefinitionNameField;
			}
			set
			{
				this.input_DefinitionNameField = value;
				this.RaisePropertyChanged("Input_DefinitionName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Node
		{
			get
			{
				return this.output_NodeField;
			}
			set
			{
				this.output_NodeField = value;
				this.RaisePropertyChanged("Output_Node");
			}
		}
	}

}