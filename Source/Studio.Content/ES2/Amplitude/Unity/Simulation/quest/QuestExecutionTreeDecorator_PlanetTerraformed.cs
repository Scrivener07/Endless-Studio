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
	public class QuestExecutionTreeDecorator_PlanetTerraformed : QuestExecutionTreeDecoratorOfEventPlanetTerraformed
	{

		private QuestInputArgument input_PlanetTypeField;

		private QuestInputArgument input_PlanetGameplayTypeField;

		private QuestInputArgument input_PlanetGUIDField;

		private QuestOutputArgument output_PlanetField;

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
		public QuestInputArgument Input_PlanetGameplayType
		{
			get
			{
				return this.input_PlanetGameplayTypeField;
			}
			set
			{
				this.input_PlanetGameplayTypeField = value;
				this.RaisePropertyChanged("Input_PlanetGameplayType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_PlanetGUID
		{
			get
			{
				return this.input_PlanetGUIDField;
			}
			set
			{
				this.input_PlanetGUIDField = value;
				this.RaisePropertyChanged("Input_PlanetGUID");
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