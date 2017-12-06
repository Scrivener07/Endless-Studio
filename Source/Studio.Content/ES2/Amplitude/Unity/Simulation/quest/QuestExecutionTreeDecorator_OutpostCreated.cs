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
	public class QuestExecutionTreeDecorator_OutpostCreated : QuestExecutionTreeDecorator_EmpireEventOfEventOutpostCreated
	{

		private QuestInputArgument input_PlanetField;

		private QuestOutputArgument output_StarSystemField;

		private QuestOutputArgument output_PlanetField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Planet
		{
			get
			{
				return this.input_PlanetField;
			}
			set
			{
				this.input_PlanetField = value;
				this.RaisePropertyChanged("Input_Planet");
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
		public QuestOutputArgument Output_Planet
		{
			get
			{
				return this.output_PlanetField;
			}
			set
			{
				this.output_PlanetField = value;
				this.RaisePropertyChanged("Output_Planet");
			}
		}
	}

}