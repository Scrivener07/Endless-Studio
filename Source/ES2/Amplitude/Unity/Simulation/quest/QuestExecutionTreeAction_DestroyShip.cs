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
	public class QuestExecutionTreeAction_DestroyShip : QuestExecutionTreeAction
	{

		private QuestOutputArgument input_ShipField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Input_Ship
		{
			get
			{
				return this.input_ShipField;
			}
			set
			{
				this.input_ShipField = value;
				this.RaisePropertyChanged("Input_Ship");
			}
		}
	}

}