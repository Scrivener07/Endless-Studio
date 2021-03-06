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
	public class QuestExecutionTreeDecorator_MinigameWon : QuestExecutionTreeDecoratorOfEventMinigameFinished
	{

		private QuestInputArgument input_MinigameGUIDField;

		private QuestInputArgument input_TeamNameField;

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
	}

}