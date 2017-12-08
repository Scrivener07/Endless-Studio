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
	public class QuestExecutionTreeDecorator_GuardNode : QuestExecutionTreeDecorator_EndTurn
	{

		private int input_DurationField;

		private bool mustBeInARowField;

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_NodeField;

		private QuestInputArgument input_FleetGUIDField;

		private QuestInputArgument input_FleetField;

		private QuestInputArgument input_ShipField;

		private QuestOutputArgument output_NodeField;

		public QuestExecutionTreeDecorator_GuardNode()
		{
			this.input_DurationField = 1;
			this.mustBeInARowField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		[DefaultValue(1)]
		public int Input_Duration
		{
			get
			{
				return this.input_DurationField;
			}
			set
			{
				this.input_DurationField = value;
				this.RaisePropertyChanged("Input_Duration");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		[DefaultValue(false)]
		public bool MustBeInARow
		{
			get
			{
				return this.mustBeInARowField;
			}
			set
			{
				this.mustBeInARowField = value;
				this.RaisePropertyChanged("MustBeInARow");
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
		public QuestInputArgument Input_FleetGUID
		{
			get
			{
				return this.input_FleetGUIDField;
			}
			set
			{
				this.input_FleetGUIDField = value;
				this.RaisePropertyChanged("Input_FleetGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleet
		{
			get
			{
				return this.input_FleetField;
			}
			set
			{
				this.input_FleetField = value;
				this.RaisePropertyChanged("Input_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Ship
		{
			get
			{
				return this.input_ShipField;
			}
			set
			{
				this.input_ShipField = value;
				this.RaisePropertyChanged("Input_Ship");
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