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
	public class QuestExecutionTreeCondition_HasGarrisonComposition : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_GarrisonsField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_RoleNameField;

		private QuestInputArgument input_RequiredTagField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Garrisons
		{
			get
			{
				return this.input_GarrisonsField;
			}
			set
			{
				this.input_GarrisonsField = value;
				this.RaisePropertyChanged("Input_Garrisons");
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
		public QuestInputArgument Input_HullName
		{
			get
			{
				return this.input_HullNameField;
			}
			set
			{
				this.input_HullNameField = value;
				this.RaisePropertyChanged("Input_HullName");
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
		public QuestInputArgument Input_RequiredTag
		{
			get
			{
				return this.input_RequiredTagField;
			}
			set
			{
				this.input_RequiredTagField = value;
				this.RaisePropertyChanged("Input_RequiredTag");
			}
		}
	}

}