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
	public class QuestExecutionTreeAction_RenameSystem : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_SystemField;

		private QuestInputArgument input_GUIDField;

		private QuestInputArgument input_NameField;

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
		public QuestInputArgument Input_GUID
		{
			get
			{
				return this.input_GUIDField;
			}
			set
			{
				this.input_GUIDField = value;
				this.RaisePropertyChanged("Input_GUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Name
		{
			get
			{
				return this.input_NameField;
			}
			set
			{
				this.input_NameField = value;
				this.RaisePropertyChanged("Input_Name");
			}
		}
	}

}