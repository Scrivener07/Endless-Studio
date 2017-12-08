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
	public class QuestInterpretedVariableDefinition : QuestVariableDefinition
	{
		private string expressionField;

		private string targetField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Expression
		{
			get { return this.expressionField; }
			set
			{
				this.expressionField = value;
				this.RaisePropertyChanged("Expression");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Target
		{
			get { return this.targetField; }
			set
			{
				this.targetField = value;
				this.RaisePropertyChanged("Target");
			}
		}


	}
}
