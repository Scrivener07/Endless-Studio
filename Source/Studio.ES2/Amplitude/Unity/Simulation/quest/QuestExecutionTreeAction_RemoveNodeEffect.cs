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
	public class QuestExecutionTreeAction_RemoveNodeEffect : QuestExecutionTreeAction
	{

		private QuestInputArgument input_NodeEffectGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_NodeEffectGUID
		{
			get
			{
				return this.input_NodeEffectGUIDField;
			}
			set
			{
				this.input_NodeEffectGUIDField = value;
				this.RaisePropertyChanged("Input_NodeEffectGUID");
			}
		}
	}

}