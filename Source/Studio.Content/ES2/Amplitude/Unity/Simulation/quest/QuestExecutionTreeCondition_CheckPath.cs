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
	public class QuestExecutionTreeCondition_CheckPath : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_SimulationObjectField;

		private QuestInputArgument input_PathField;

		private CheckComposition compositionField;

		private bool allowFailureIfNoSimObjectField;

		public QuestExecutionTreeCondition_CheckPath()
		{
			this.compositionField = CheckComposition.Any;
			this.allowFailureIfNoSimObjectField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SimulationObject
		{
			get
			{
				return this.input_SimulationObjectField;
			}
			set
			{
				this.input_SimulationObjectField = value;
				this.RaisePropertyChanged("Input_SimulationObject");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Path
		{
			get
			{
				return this.input_PathField;
			}
			set
			{
				this.input_PathField = value;
				this.RaisePropertyChanged("Input_Path");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(CheckComposition.Any)]
		public CheckComposition Composition
		{
			get
			{
				return this.compositionField;
			}
			set
			{
				this.compositionField = value;
				this.RaisePropertyChanged("Composition");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool AllowFailureIfNoSimObject
		{
			get
			{
				return this.allowFailureIfNoSimObjectField;
			}
			set
			{
				this.allowFailureIfNoSimObjectField = value;
				this.RaisePropertyChanged("AllowFailureIfNoSimObject");
			}
		}
	}

}