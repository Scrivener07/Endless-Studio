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
	public class QuestExecutionTreeAction_AssignHero : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_HeroGUIDField;

		private QuestInputArgument input_LocationGUIDField;

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
		public QuestInputArgument Input_HeroGUID
		{
			get
			{
				return this.input_HeroGUIDField;
			}
			set
			{
				this.input_HeroGUIDField = value;
				this.RaisePropertyChanged("Input_HeroGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_LocationGUID
		{
			get
			{
				return this.input_LocationGUIDField;
			}
			set
			{
				this.input_LocationGUIDField = value;
				this.RaisePropertyChanged("Input_LocationGUID");
			}
		}
	}

}