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
	public class QuestExecutionTreeAction_RemoveQuestEffect : QuestExecutionTreeAction
	{

		private QuestInputArgument input_GUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_GUID
		{
			get
			{
				return this.input_GUIDField;
			}
			set
			{
				this.input_GUIDField = value;
				this.RaisePropertyChanged("Input_GUID");
			}
		}
	}

}