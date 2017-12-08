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
	public class QuestExecutionTreeDecorator_InvadeSystem : QuestExecutionTreeDecoratorOfEventGroundBattleWon
	{

		private QuestInputArgument input_SystemField;

		private QuestInputArgument input_NodeTypeField;

		private QuestInputArgument input_VictimEmpireField;

		private int input_CountField;

		private QuestOutputArgument output_StarSystemField;

		private QuestOutputArgument output_VictimEmpireField;

		public QuestExecutionTreeDecorator_InvadeSystem()
		{
			this.input_CountField = 1;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_System
		{
			get
			{
				return this.input_SystemField;
			}
			set
			{
				this.input_SystemField = value;
				this.RaisePropertyChanged("Input_System");
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
		public QuestInputArgument Input_VictimEmpire
		{
			get
			{
				return this.input_VictimEmpireField;
			}
			set
			{
				this.input_VictimEmpireField = value;
				this.RaisePropertyChanged("Input_VictimEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		[DefaultValue(1)]
		public int Input_Count
		{
			get
			{
				return this.input_CountField;
			}
			set
			{
				this.input_CountField = value;
				this.RaisePropertyChanged("Input_Count");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_StarSystem
		{
			get
			{
				return this.output_StarSystemField;
			}
			set
			{
				this.output_StarSystemField = value;
				this.RaisePropertyChanged("Output_StarSystem");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_VictimEmpire
		{
			get
			{
				return this.output_VictimEmpireField;
			}
			set
			{
				this.output_VictimEmpireField = value;
				this.RaisePropertyChanged("Output_VictimEmpire");
			}
		}
	}

}