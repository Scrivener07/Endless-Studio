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
	public class QuestExecutionTreeDecorator_GovernmentChanged : QuestExecutionTreeDecoratorOfEventGovernmentStarted
	{

		private QuestInputArgument input_GovernmentTypeField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_GovernmentType
		{
			get
			{
				return this.input_GovernmentTypeField;
			}
			set
			{
				this.input_GovernmentTypeField = value;
				this.RaisePropertyChanged("Input_GovernmentType");
			}
		}
	}

}