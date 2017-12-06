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
	public class QuestExecutionTreeAction_Colonize : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_PlanetField;

		private QuestInputArgument input_PlanetGUIDField;

		private QuestOutputArgument output_ColonizedStarSystemGUIDField;

		private QuestOutputArgument output_ColonizedPlanetGUIDField;

		private bool outpostField;

		public QuestExecutionTreeAction_Colonize()
		{
			this.outpostField = false;
		}

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
		public QuestOutputArgument Output_ColonizedStarSystemGUID
		{
			get
			{
				return this.output_ColonizedStarSystemGUIDField;
			}
			set
			{
				this.output_ColonizedStarSystemGUIDField = value;
				this.RaisePropertyChanged("Output_ColonizedStarSystemGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_ColonizedPlanetGUID
		{
			get
			{
				return this.output_ColonizedPlanetGUIDField;
			}
			set
			{
				this.output_ColonizedPlanetGUIDField = value;
				this.RaisePropertyChanged("Output_ColonizedPlanetGUID");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Outpost
		{
			get
			{
				return this.outpostField;
			}
			set
			{
				this.outpostField = value;
				this.RaisePropertyChanged("Outpost");
			}
		}
	}

}