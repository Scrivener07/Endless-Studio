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
	public class QuestExecutionTreeDecorator_PopulationGained : QuestExecutionTreeDecorator_EmpireEventOfEventPopulationGained
	{

		private int input_CountField;

		private QuestInputArgument input_ColonizedStarSystemField;

		private QuestInputArgument input_AffinityField;

		private QuestInputArgument input_MainPoliticsField;

		private QuestOutputArgument output_ColonizedStarSystemField;

		public QuestExecutionTreeDecorator_PopulationGained()
		{
			this.input_CountField = 1;
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
		public QuestInputArgument Input_ColonizedStarSystem
		{
			get
			{
				return this.input_ColonizedStarSystemField;
			}
			set
			{
				this.input_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Input_ColonizedStarSystem");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Affinity
		{
			get
			{
				return this.input_AffinityField;
			}
			set
			{
				this.input_AffinityField = value;
				this.RaisePropertyChanged("Input_Affinity");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MainPolitics
		{
			get
			{
				return this.input_MainPoliticsField;
			}
			set
			{
				this.input_MainPoliticsField = value;
				this.RaisePropertyChanged("Input_MainPolitics");
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