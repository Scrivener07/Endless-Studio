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
	public class QuestExecutionTreeCondition_FleetShipStats : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_FleetsField;

		private QuestInputArgument input_FleetGUIDsField;

		private QuestInputArgument input_ModuleTypeField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_RoleNameField;

		private QuestInputArgument input_MinimumManpowerAmountField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleets
		{
			get
			{
				return this.input_FleetsField;
			}
			set
			{
				this.input_FleetsField = value;
				this.RaisePropertyChanged("Input_Fleets");
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
		public QuestInputArgument Input_ModuleType
		{
			get
			{
				return this.input_ModuleTypeField;
			}
			set
			{
				this.input_ModuleTypeField = value;
				this.RaisePropertyChanged("Input_ModuleType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ModuleName
		{
			get
			{
				return this.input_ModuleNameField;
			}
			set
			{
				this.input_ModuleNameField = value;
				this.RaisePropertyChanged("Input_ModuleName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_RoleName
		{
			get
			{
				return this.input_RoleNameField;
			}
			set
			{
				this.input_RoleNameField = value;
				this.RaisePropertyChanged("Input_RoleName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumManpowerAmount
		{
			get
			{
				return this.input_MinimumManpowerAmountField;
			}
			set
			{
				this.input_MinimumManpowerAmountField = value;
				this.RaisePropertyChanged("Input_MinimumManpowerAmount");
			}
		}
	}

}