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
	public class QuestExecutionTreeAction_RemoveCuriosity : QuestExecutionTreeAction
	{

		private QuestInputArgument input_CuriosityGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_CuriosityGUID
		{
			get
			{
				return this.input_CuriosityGUIDField;
			}
			set
			{
				this.input_CuriosityGUIDField = value;
				this.RaisePropertyChanged("Input_CuriosityGUID");
			}
		}
	}

}