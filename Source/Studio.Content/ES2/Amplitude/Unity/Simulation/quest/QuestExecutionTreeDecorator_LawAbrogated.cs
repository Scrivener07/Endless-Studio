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
	public class QuestExecutionTreeDecorator_LawAbrogated : QuestExecutionTreeDecorator_EmpireEventOfEventLawAbrogated
	{

		private QuestInputArgument input_LawNameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_LawName
		{
			get
			{
				return this.input_LawNameField;
			}
			set
			{
				this.input_LawNameField = value;
				this.RaisePropertyChanged("Input_LawName");
			}
		}
	}

}