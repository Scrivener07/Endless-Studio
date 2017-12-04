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
	public class QuestExecutionTreeCondition_HasSpecialNodes : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MaximumAmountField;

		private QuestInputArgument input_NodeTypeField;

		private QuestInputArgument input_NodesField;

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
		public QuestInputArgument Input_MinimumAmount
		{
			get
			{
				return this.input_MinimumAmountField;
			}
			set
			{
				this.input_MinimumAmountField = value;
				this.RaisePropertyChanged("Input_MinimumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumAmount
		{
			get
			{
				return this.input_MaximumAmountField;
			}
			set
			{
				this.input_MaximumAmountField = value;
				this.RaisePropertyChanged("Input_MaximumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NodeType
		{
			get
			{
				return this.input_NodeTypeField;
			}
			set
			{
				this.input_NodeTypeField = value;
				this.RaisePropertyChanged("Input_NodeType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Nodes
		{
			get
			{
				return this.input_NodesField;
			}
			set
			{
				this.input_NodesField = value;
				this.RaisePropertyChanged("Input_Nodes");
			}
		}
	}

}