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
	public class QuestExecutionTreeAction_SwitchEmpireFaction : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private string factionNameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empire
		{
			get
			{
				return this.input_EmpireField;
			}
			set
			{
				this.input_EmpireField = value;
				this.RaisePropertyChanged("Input_Empire");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string FactionName
		{
			get
			{
				return this.factionNameField;
			}
			set
			{
				this.factionNameField = value;
				this.RaisePropertyChanged("FactionName");
			}
		}
	}

}