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
	public class QuestExecutionTreeController_Loop : QuestExecutionTreeController_Sequence
	{

		private QuestInputArgument input_CountField;

		private int countField;

		public QuestExecutionTreeController_Loop()
		{
			this.countField = 1;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Count
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
		[XmlAttribute]
		[DefaultValue(1)]
		public int Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}
	}

}