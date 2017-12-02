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
	public class QuestExecutionTreeAction_StartMinigame : QuestExecutionTreeAction
	{

		private QuestInputArgument input_MinigameNameField;

		private QuestInputArgument input_GameNodesField;

		private QuestOutputArgument output_MinigameGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinigameName
		{
			get
			{
				return this.input_MinigameNameField;
			}
			set
			{
				this.input_MinigameNameField = value;
				this.RaisePropertyChanged("Input_MinigameName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_GameNodes
		{
			get
			{
				return this.input_GameNodesField;
			}
			set
			{
				this.input_GameNodesField = value;
				this.RaisePropertyChanged("Input_GameNodes");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_MinigameGUID
		{
			get
			{
				return this.output_MinigameGUIDField;
			}
			set
			{
				this.output_MinigameGUIDField = value;
				this.RaisePropertyChanged("Output_MinigameGUID");
			}
		}
	}

}