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
	public class QuestExecutionTreeDecoratorMinigameObjectiveSecured : QuestExecutionTreeDecoratorOfEventMinigameObjectiveSecured
	{

		private QuestInputArgument input_MinigameGUIDField;

		private QuestInputArgument input_TeamNameField;

		private QuestOutputArgument output_SystemField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinigameGUID
		{
			get
			{
				return this.input_MinigameGUIDField;
			}
			set
			{
				this.input_MinigameGUIDField = value;
				this.RaisePropertyChanged("Input_MinigameGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TeamName
		{
			get
			{
				return this.input_TeamNameField;
			}
			set
			{
				this.input_TeamNameField = value;
				this.RaisePropertyChanged("Input_TeamName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_System
		{
			get
			{
				return this.output_SystemField;
			}
			set
			{
				this.output_SystemField = value;
				this.RaisePropertyChanged("Output_System");
			}
		}
	}

}