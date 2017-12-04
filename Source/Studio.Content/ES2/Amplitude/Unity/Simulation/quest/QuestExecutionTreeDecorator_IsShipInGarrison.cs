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
	public class QuestExecutionTreeDecorator_IsShipInGarrison : QuestExecutionTreeDecoratorOfEventGarrisonCompositionChanged
	{

		private QuestInputArgument input_GarrisonField;

		private QuestInputArgument input_ShipField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Garrison
		{
			get
			{
				return this.input_GarrisonField;
			}
			set
			{
				this.input_GarrisonField = value;
				this.RaisePropertyChanged("Input_Garrison");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Ship
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