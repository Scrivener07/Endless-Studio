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
	public class QuestExecutionTreeDecorator_BattleEnded : QuestExecutionTreeDecorator_EmpireEventOfEventBattleEnded
	{

		private QuestInputArgument input_HeroField;

		private QuestInputArgument input_EmpireField;

		private QuestOutputArgument output_NodeField;

		private BattleState statusField;

		public QuestExecutionTreeDecorator_BattleEnded()
		{
			this.statusField = BattleState.DontCare;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Hero
		{
			get
			{
				return this.input_HeroField;
			}
			set
			{
				this.input_HeroField = value;
				this.RaisePropertyChanged("Input_Hero");
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
		[XmlAttribute]
		[DefaultValue(BattleState.DontCare)]
		public BattleState Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("Status");
			}
		}
	}

}