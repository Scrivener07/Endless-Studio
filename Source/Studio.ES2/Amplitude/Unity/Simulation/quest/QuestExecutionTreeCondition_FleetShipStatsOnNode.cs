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
	public class QuestExecutionTreeCondition_FleetShipStatsOnNode : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_NodeField;

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_ModuleTypeField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_RoleNameField;

		private QuestInputArgument input_MinimumMilitaryPowerField;

		private QuestInputArgument input_MinimumOffensiveMilitaryPowerField;

		private QuestInputArgument input_MinimumManpowerAmountField;

		private QuestInputArgument input_MinimumAmountField;

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
		public QuestInputArgument Input_MinimumMilitaryPower
		{
			get
			{
				return this.input_MinimumMilitaryPowerField;
			}
			set
			{
				this.input_MinimumMilitaryPowerField = value;
				this.RaisePropertyChanged("Input_MinimumMilitaryPower");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumOffensiveMilitaryPower
		{
			get
			{
				return this.input_MinimumOffensiveMilitaryPowerField;
			}
			set
			{
				this.input_MinimumOffensiveMilitaryPowerField = value;
				this.RaisePropertyChanged("Input_MinimumOffensiveMilitaryPower");
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
	}

}