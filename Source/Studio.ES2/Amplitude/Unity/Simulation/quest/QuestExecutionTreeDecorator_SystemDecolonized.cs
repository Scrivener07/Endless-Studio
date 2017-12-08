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
	public class QuestExecutionTreeDecorator_SystemDecolonized : QuestExecutionTreeDecorator_EmpireEventOfEventSystemDecolonized
	{

		private QuestInputArgument input_SystemsField;

		private QuestInputArgument input_SystemGUIDsField;

		private QuestOutputArgument output_StarSystemField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Systems
		{
			get
			{
				return this.input_SystemsField;
			}
			set
			{
				this.input_SystemsField = value;
				this.RaisePropertyChanged("Input_Systems");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SystemGUIDs
		{
			get
			{
				return this.input_SystemGUIDsField;
			}
			set
			{
				this.input_SystemGUIDsField = value;
				this.RaisePropertyChanged("Input_SystemGUIDs");
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
	}

}