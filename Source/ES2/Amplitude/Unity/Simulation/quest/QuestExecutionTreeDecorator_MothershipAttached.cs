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
	public class QuestExecutionTreeDecorator_MothershipAttached : QuestExecutionTreeDecorator_EmpireEventOfEventMothershipAttached
	{

		private QuestInputArgument input_SystemField;

		private QuestInputArgument input_SystemTypeField;

		private QuestOutputArgument output_StarSystemField;

		private QuestOutputArgument output_ColonizedStarSystemField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_System
		{
			get
			{
				return this.input_SystemField;
			}
			set
			{
				this.input_SystemField = value;
				this.RaisePropertyChanged("Input_System");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SystemType
		{
			get
			{
				return this.input_SystemTypeField;
			}
			set
			{
				this.input_SystemTypeField = value;
				this.RaisePropertyChanged("Input_SystemType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_StarSystem
		{
			get
			{
				return this.output_StarSystemField;
			}
			set
			{
				this.output_StarSystemField = value;
				this.RaisePropertyChanged("Output_StarSystem");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_ColonizedStarSystem
		{
			get
			{
				return this.output_ColonizedStarSystemField;
			}
			set
			{
				this.output_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Output_ColonizedStarSystem");
			}
		}
	}

}