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
	public class QuestExecutionTreeDecorator_PlanetDestroyed : QuestExecutionTreeDecorator_EmpireEventOfEventPlanetDestroyed
	{

		private QuestInputArgument input_PlanetField;

		private QuestInputArgument input_TypeField;

		private QuestInputArgument input_GameplayTypeField;

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
		public QuestInputArgument Input_Type
		{
			get
			{
				return this.input_TypeField;
			}
			set
			{
				this.input_TypeField = value;
				this.RaisePropertyChanged("Input_Type");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_GameplayType
		{
			get
			{
				return this.input_GameplayTypeField;
			}
			set
			{
				this.input_GameplayTypeField = value;
				this.RaisePropertyChanged("Input_GameplayType");
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