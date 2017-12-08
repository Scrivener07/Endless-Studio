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
	public class QuestExecutionTreeDecorator_FleetDocked : QuestExecutionTreeDecorator_EmpireEventOfEventFleetDocked
	{

		private QuestInputArgument input_SystemField;

		private QuestInputArgument input_SystemsField;

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_FleetField;

		private QuestInputArgument input_SystemTypeField;

		private QuestOutputArgument output_NodeField;

		private QuestOutputArgument output_FleetField;

		private QuestOutputArgument output_FleetGUIDField;

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
		public QuestInputArgument Input_Systems
		{
			get
			{
				return this.input_SystemsField;
			}
			set
			{
				this.input_SystemsField = value;
				this.RaisePropertyChanged("Input_Systems");
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
		public QuestInputArgument Input_SystemType
		{
			get
			{
				return this.input_SystemTypeField;
			}
			set
			{
				this.input_SystemTypeField = value;
				this.RaisePropertyChanged("Input_SystemType");
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
		public QuestOutputArgument Output_Fleet
		{
			get
			{
				return this.output_FleetField;
			}
			set
			{
				this.output_FleetField = value;
				this.RaisePropertyChanged("Output_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_FleetGUID
		{
			get
			{
				return this.output_FleetGUIDField;
			}
			set
			{
				this.output_FleetGUIDField = value;
				this.RaisePropertyChanged("Output_FleetGUID");
			}
		}
	}

}