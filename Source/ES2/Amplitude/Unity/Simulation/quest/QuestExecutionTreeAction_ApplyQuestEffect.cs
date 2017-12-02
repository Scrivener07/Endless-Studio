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
	public class QuestExecutionTreeAction_ApplyQuestEffect : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EffectNameField;

		private QuestInputArgument input_TargetField;

		private QuestOutputArgument output_GUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_EffectName
		{
			get
			{
				return this.input_EffectNameField;
			}
			set
			{
				this.input_EffectNameField = value;
				this.RaisePropertyChanged("Input_EffectName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Target
		{
			get
			{
				return this.input_TargetField;
			}
			set
			{
				this.input_TargetField = value;
				this.RaisePropertyChanged("Input_Target");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_GUID
		{
			get
			{
				return this.output_GUIDField;
			}
			set
			{
				this.output_GUIDField = value;
				this.RaisePropertyChanged("Output_GUID");
			}
		}
	}

}