using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeDecorator_Tutorial_DisplayedTutorialChanged))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_DisplayedTutorialChanged : QuestExecutionTreeDecoratorOfEventTutorial_DisplayedTutorialChanged
	{

		private QuestOutputArgument output_EmpireField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Empire
		{
			get
			{
				return this.output_EmpireField;
			}
			set
			{
				this.output_EmpireField = value;
				this.RaisePropertyChanged("Output_Empire");
			}
		}
	}

}