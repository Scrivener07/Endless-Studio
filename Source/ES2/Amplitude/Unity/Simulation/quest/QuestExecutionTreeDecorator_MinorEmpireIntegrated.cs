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
	public class QuestExecutionTreeDecorator_MinorEmpireIntegrated : QuestExecutionTreeDecorator_EmpireEventOfEventMinorEmpireIntegrated
	{

		private QuestInputArgument input_MajorEmpireField;

		private QuestInputArgument input_MinorEmpireField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MajorEmpire
		{
			get
			{
				return this.input_MajorEmpireField;
			}
			set
			{
				this.input_MajorEmpireField = value;
				this.RaisePropertyChanged("Input_MajorEmpire");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinorEmpire
		{
			get
			{
				return this.input_MinorEmpireField;
			}
			set
			{
				this.input_MinorEmpireField = value;
				this.RaisePropertyChanged("Input_MinorEmpire");
			}
		}
	}

}