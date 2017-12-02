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
	public class QuestExecutionTreeCondition_BattleEnded_FleetDestroyed : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_FleetGUIDsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_FleetGUIDs
		{
			get
			{
				return this.input_FleetGUIDsField;
			}
			set
			{
				this.input_FleetGUIDsField = value;
				this.RaisePropertyChanged("Input_FleetGUIDs");
			}
		}
	}

}