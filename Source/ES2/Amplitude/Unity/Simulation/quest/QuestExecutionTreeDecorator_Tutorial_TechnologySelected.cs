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
	public class QuestExecutionTreeDecorator_Tutorial_TechnologySelected : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_TechnologySelected
	{

		private QuestInputArgument input_TechnologyNameField;

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
	}

}