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
	public class QuestExecutionTreeCondition_CountSimulationObjectsWithTag : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_SimulationObjectsField;

		private QuestInputArgument input_PathField;

		private QuestInputArgument input_SubPathField;

		private QuestInputArgument input_TagField;

		private QuestInputArgument input_MinimumField;

		private QuestInputArgument input_SubMinimumField;

		private CountValidationType compositionField;

		private CountValidationType subCompositionField;

		public QuestExecutionTreeCondition_CountSimulationObjectsWithTag()
		{
			this.compositionField = CountValidationType.Minimum;
			this.subCompositionField = CountValidationType.Minimum;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SimulationObjects
		{
			get
			{
				return this.input_SimulationObjectsField;
			}
			set
			{
				this.input_SimulationObjectsField = value;
				this.RaisePropertyChanged("Input_SimulationObjects");
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
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SubPath
		{
			get
			{
				return this.input_SubPathField;
			}
			set
			{
				this.input_SubPathField = value;
				this.RaisePropertyChanged("Input_SubPath");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Tag
		{
			get
			{
				return this.input_TagField;
			}
			set
			{
				this.input_TagField = value;
				this.RaisePropertyChanged("Input_Tag");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Minimum
		{
			get
			{
				return this.input_MinimumField;
			}
			set
			{
				this.input_MinimumField = value;
				this.RaisePropertyChanged("Input_Minimum");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_SubMinimum
		{
			get
			{
				return this.input_SubMinimumField;
			}
			set
			{
				this.input_SubMinimumField = value;
				this.RaisePropertyChanged("Input_SubMinimum");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(CountValidationType.Minimum)]
		public CountValidationType Composition
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
		[DefaultValue(CountValidationType.Minimum)]
		public CountValidationType SubComposition
		{
			get
			{
				return this.subCompositionField;
			}
			set
			{
				this.subCompositionField = value;
				this.RaisePropertyChanged("SubComposition");
			}
		}
	}

}