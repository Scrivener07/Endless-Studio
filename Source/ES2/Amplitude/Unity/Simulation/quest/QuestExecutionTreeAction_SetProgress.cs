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
	public class QuestExecutionTreeAction_SetProgress : QuestExecutionTreeAction
	{

		private QuestInputArgument input_ValueField;

		private bool isIncrementField;

		public QuestExecutionTreeAction_SetProgress()
		{
			this.isIncrementField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Value
		{
			get
			{
				return this.input_ValueField;
			}
			set
			{
				this.input_ValueField = value;
				this.RaisePropertyChanged("Input_Value");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsIncrement
		{
			get
			{
				return this.isIncrementField;
			}
			set
			{
				this.isIncrementField = value;
				this.RaisePropertyChanged("IsIncrement");
			}
		}
	}

}