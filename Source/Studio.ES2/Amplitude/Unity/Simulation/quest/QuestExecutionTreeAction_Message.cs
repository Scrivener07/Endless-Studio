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
	public class QuestExecutionTreeAction_Message : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpiresField;

		private string messageField;

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
		[XmlAttribute]
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
				this.RaisePropertyChanged("Message");
			}
		}
	}

}