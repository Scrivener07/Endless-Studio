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
	public class QuestExecutionTreeDecorator_Tutorial_DisplayedTutorialChanged : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_DisplayedTutorialChanged
	{

		private QuestInputArgument input_TutorialNameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TutorialName
		{
			get
			{
				return this.input_TutorialNameField;
			}
			set
			{
				this.input_TutorialNameField = value;
				this.RaisePropertyChanged("Input_TutorialName");
			}
		}
	}

}