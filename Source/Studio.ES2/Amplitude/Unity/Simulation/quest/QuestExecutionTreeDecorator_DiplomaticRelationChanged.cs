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
	public class QuestExecutionTreeDecorator_DiplomaticRelationChanged : QuestExecutionTreeDecoratorOfEventDiplomaticRelationChange
	{

		private QuestInputArgument input_OtherEmpireField;

		private QuestInputArgument input_DiplomaticRelationStateField;

		private QuestOutputArgument output_OtherEmpireField;

		private QuestOutputArgument output_DiplomaticRelationStateField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_OtherEmpire
		{
			get
			{
				return this.input_OtherEmpireField;
			}
			set
			{
				this.input_OtherEmpireField = value;
				this.RaisePropertyChanged("Input_OtherEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DiplomaticRelationState
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
		public QuestOutputArgument Output_OtherEmpire
		{
			get
			{
				return this.output_OtherEmpireField;
			}
			set
			{
				this.output_OtherEmpireField = value;
				this.RaisePropertyChanged("Output_OtherEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_DiplomaticRelationState
		{
			get
			{
				return this.output_DiplomaticRelationStateField;
			}
			set
			{
				this.output_DiplomaticRelationStateField = value;
				this.RaisePropertyChanged("Output_DiplomaticRelationState");
			}
		}
	}

}