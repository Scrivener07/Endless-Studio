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
	public class QuestExecutionTreeCondition_HasFleets : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_RoleNameField;

		private int minimumField;

		private int maximumField;

		public QuestExecutionTreeCondition_HasFleets()
		{
			this.minimumField = -2147483648;
			this.maximumField = 2147483647;
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
		[XmlAttribute]
		[DefaultValue(-2147483648)]
		public int Minimum
		{
			get
			{
				return this.minimumField;
			}
			set
			{
				this.minimumField = value;
				this.RaisePropertyChanged("Minimum");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(2147483647)]
		public int Maximum
		{
			get
			{
				return this.maximumField;
			}
			set
			{
				this.maximumField = value;
				this.RaisePropertyChanged("Maximum");
			}
		}
	}

}