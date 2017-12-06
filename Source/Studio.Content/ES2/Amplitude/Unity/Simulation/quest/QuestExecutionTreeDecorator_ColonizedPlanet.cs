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
	public class QuestExecutionTreeDecorator_ColonizedPlanet : QuestExecutionTreeDecorator_EmpireEventOfEventOnColonizedPlanet
	{

		private QuestInputArgument input_PlanetField;

		private int input_CountField;

		private QuestInputArgument input_PlanetTypeField;

		private QuestOutputArgument output_PlanetField;

		private QuestOutputArgument output_SystemField;

		public QuestExecutionTreeDecorator_ColonizedPlanet()
		{
			this.input_CountField = 1;
		}

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
		[DefaultValue(1)]
		public int Input_Count
		{
			get
			{
				return this.input_CountField;
			}
			set
			{
				this.input_CountField = value;
				this.RaisePropertyChanged("Input_Count");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PlanetType
		{
			get
			{
				return this.input_PlanetTypeField;
			}
			set
			{
				this.input_PlanetTypeField = value;
				this.RaisePropertyChanged("Input_PlanetType");
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

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_System
		{
			get
			{
				return this.output_SystemField;
			}
			set
			{
				this.output_SystemField = value;
				this.RaisePropertyChanged("Output_System");
			}
		}
	}

}