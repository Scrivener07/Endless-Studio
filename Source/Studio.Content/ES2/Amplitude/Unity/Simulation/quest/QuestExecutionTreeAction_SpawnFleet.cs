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
	public class QuestExecutionTreeAction_SpawnFleet : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_LocationsField;

		private QuestInputArgument input_DroppableFleetField;

		private QuestInputArgument input_DroplistNameField;

		private QuestInputArgument input_CountField;

		private QuestInputArgument input_FleetNameField;

		private QuestOutputArgument output_FleetGUIDsField;

		private bool lockShipsInTheFleetField;

		public QuestExecutionTreeAction_SpawnFleet()
		{
			this.lockShipsInTheFleetField = false;
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
		public QuestInputArgument Input_Locations
		{
			get
			{
				return this.input_LocationsField;
			}
			set
			{
				this.input_LocationsField = value;
				this.RaisePropertyChanged("Input_Locations");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DroppableFleet
		{
			get
			{
				return this.input_DroppableFleetField;
			}
			set
			{
				this.input_DroppableFleetField = value;
				this.RaisePropertyChanged("Input_DroppableFleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DroplistName
		{
			get
			{
				return this.input_DroplistNameField;
			}
			set
			{
				this.input_DroplistNameField = value;
				this.RaisePropertyChanged("Input_DroplistName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Count
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
		public QuestInputArgument Input_FleetName
		{
			get
			{
				return this.input_FleetNameField;
			}
			set
			{
				this.input_FleetNameField = value;
				this.RaisePropertyChanged("Input_FleetName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_FleetGUIDs
		{
			get
			{
				return this.output_FleetGUIDsField;
			}
			set
			{
				this.output_FleetGUIDsField = value;
				this.RaisePropertyChanged("Output_FleetGUIDs");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool LockShipsInTheFleet
		{
			get
			{
				return this.lockShipsInTheFleetField;
			}
			set
			{
				this.lockShipsInTheFleetField = value;
				this.RaisePropertyChanged("LockShipsInTheFleet");
			}
		}
	}

}