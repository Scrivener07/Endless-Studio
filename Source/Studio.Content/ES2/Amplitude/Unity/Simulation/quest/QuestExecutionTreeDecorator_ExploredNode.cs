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
	public class QuestExecutionTreeDecorator_ExploredNode : QuestExecutionTreeDecorator_EmpireEventOfEventGameNodeDiscovered
	{

		private QuestInputArgument input_NodeListField;

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_MinimumPercentageField;

		private QuestOutputArgument output_NodeField;

		private QuestOutputArgument output_PercentageField;

		private State minimumStateField;

		private State maximumPreviousStateField;

		public QuestExecutionTreeDecorator_ExploredNode()
		{
			this.minimumStateField = State.Revealed;
			this.maximumPreviousStateField = State.Owned;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NodeList
		{
			get
			{
				return this.input_NodeListField;
			}
			set
			{
				this.input_NodeListField = value;
				this.RaisePropertyChanged("Input_NodeList");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empires
		{
			get
			{
				return this.input_EmpiresField;
			}
			set
			{
				this.input_EmpiresField = value;
				this.RaisePropertyChanged("Input_Empires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumPercentage
		{
			get
			{
				return this.input_MinimumPercentageField;
			}
			set
			{
				this.input_MinimumPercentageField = value;
				this.RaisePropertyChanged("Input_MinimumPercentage");
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

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Percentage
		{
			get
			{
				return this.output_PercentageField;
			}
			set
			{
				this.output_PercentageField = value;
				this.RaisePropertyChanged("Output_Percentage");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(State.Revealed)]
		public State MinimumState
		{
			get
			{
				return this.minimumStateField;
			}
			set
			{
				this.minimumStateField = value;
				this.RaisePropertyChanged("MinimumState");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(State.Owned)]
		public State MaximumPreviousState
		{
			get
			{
				return this.maximumPreviousStateField;
			}
			set
			{
				this.maximumPreviousStateField = value;
				this.RaisePropertyChanged("MaximumPreviousState");
			}
		}
	}

}