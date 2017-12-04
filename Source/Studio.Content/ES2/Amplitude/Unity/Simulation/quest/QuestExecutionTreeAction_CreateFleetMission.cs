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
	public class QuestExecutionTreeAction_CreateFleetMission : QuestExecutionTreeAction
	{

		private QuestInputArgument input_MissionDefinitionNameField;

		private QuestInputArgument input_FleetGUIDsField;

		private QuestInputArgument input_TargetEmpiresField;

		private QuestInputArgument input_TargetsField;

		private QuestOutputArgument output_MissionGUIDsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MissionDefinitionName
		{
			get
			{
				return this.input_MissionDefinitionNameField;
			}
			set
			{
				this.input_MissionDefinitionNameField = value;
				this.RaisePropertyChanged("Input_MissionDefinitionName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_FleetGUIDs
		{
			get
			{
				return this.input_FleetGUIDsField;
			}
			set
			{
				this.input_FleetGUIDsField = value;
				this.RaisePropertyChanged("Input_FleetGUIDs");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TargetEmpires
		{
			get
			{
				return this.input_TargetEmpiresField;
			}
			set
			{
				this.input_TargetEmpiresField = value;
				this.RaisePropertyChanged("Input_TargetEmpires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Targets
		{
			get
			{
				return this.input_TargetsField;
			}
			set
			{
				this.input_TargetsField = value;
				this.RaisePropertyChanged("Input_Targets");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_MissionGUIDs
		{
			get
			{
				return this.output_MissionGUIDsField;
			}
			set
			{
				this.output_MissionGUIDsField = value;
				this.RaisePropertyChanged("Output_MissionGUIDs");
			}
		}
	}

}