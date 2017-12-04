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
	public class QuestExecutionTreeDecorator_HeroRecruited : QuestExecutionTreeDecorator_EmpireEventOfEventHeroRecruited
	{

		private QuestInputArgument input_HeroNameField;

		private QuestOutputArgument output_HeroField;

		private QuestOutputArgument output_HeroGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroName
		{
			get
			{
				return this.input_HeroNameField;
			}
			set
			{
				this.input_HeroNameField = value;
				this.RaisePropertyChanged("Input_HeroName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Hero
		{
			get
			{
				return this.output_HeroField;
			}
			set
			{
				this.output_HeroField = value;
				this.RaisePropertyChanged("Output_Hero");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_HeroGUID
		{
			get
			{
				return this.output_HeroGUIDField;
			}
			set
			{
				this.output_HeroGUIDField = value;
				this.RaisePropertyChanged("Output_HeroGUID");
			}
		}
	}

}