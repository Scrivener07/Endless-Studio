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
	public class QuestExecutionTreeAction_RevealEntities : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_TargetSystemsField;

		private State newExplorationStateField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empires
		{
			get
			{
				return this.input_EmpiresField;
			}
			set
			{
				this.input_EmpiresField = value;
				this.RaisePropertyChanged("Input_Empires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TargetSystems
		{
			get
			{
				return this.input_TargetSystemsField;
			}
			set
			{
				this.input_TargetSystemsField = value;
				this.RaisePropertyChanged("Input_TargetSystems");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public State NewExplorationState
		{
			get
			{
				return this.newExplorationStateField;
			}
			set
			{
				this.newExplorationStateField = value;
				this.RaisePropertyChanged("NewExplorationState");
			}
		}
	}

}