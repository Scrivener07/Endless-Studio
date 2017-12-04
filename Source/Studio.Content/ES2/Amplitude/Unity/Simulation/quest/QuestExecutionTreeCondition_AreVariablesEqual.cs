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
	public class QuestExecutionTreeCondition_AreVariablesEqual : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_Variable1Field;

		private QuestInputArgument input_Variable2Field;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Variable1
		{
			get
			{
				return this.input_Variable1Field;
			}
			set
			{
				this.input_Variable1Field = value;
				this.RaisePropertyChanged("Input_Variable1");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Variable2
		{
			get
			{
				return this.input_Variable2Field;
			}
			set
			{
				this.input_Variable2Field = value;
				this.RaisePropertyChanged("Input_Variable2");
			}
		}
	}

}