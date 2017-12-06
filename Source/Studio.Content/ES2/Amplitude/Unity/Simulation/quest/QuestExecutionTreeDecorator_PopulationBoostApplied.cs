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
	public class QuestExecutionTreeDecorator_PopulationBoostApplied : QuestExecutionTreeDecorator_EmpireEventOfEventPopulationBoostApplied
	{

		private QuestInputArgument input_AffinityField;

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
	}

}