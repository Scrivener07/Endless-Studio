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
	public class QuestExecutionTreeAction_UnlockTechnology : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_TechnologyNameField;

		private QuestInputArgument input_ConstructibleNameField;

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
		public QuestInputArgument Input_TechnologyName
		{
			get
			{
				return this.input_TechnologyNameField;
			}
			set
			{
				this.input_TechnologyNameField = value;
				this.RaisePropertyChanged("Input_TechnologyName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ConstructibleName
		{
			get
			{
				return this.input_ConstructibleNameField;
			}
			set
			{
				this.input_ConstructibleNameField = value;
				this.RaisePropertyChanged("Input_ConstructibleName");
			}
		}
	}

}