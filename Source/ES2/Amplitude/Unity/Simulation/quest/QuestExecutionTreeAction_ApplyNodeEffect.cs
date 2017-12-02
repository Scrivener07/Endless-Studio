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
	public class QuestExecutionTreeAction_ApplyNodeEffect : QuestExecutionTreeAction
	{

		private QuestInputArgument input_TargetsField;

		private QuestInputArgument input_TargetGUIDsField;

		private QuestInputArgument input_DefinitionNameField;

		private QuestOutputArgument output_NodeEffectGUIDField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Targets
		{
			get
			{
				return this.input_TargetsField;
			}
			set
			{
				this.input_TargetsField = value;
				this.RaisePropertyChanged("Input_Targets");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_TargetGUIDs
		{
			get
			{
				return this.input_TargetGUIDsField;
			}
			set
			{
				this.input_TargetGUIDsField = value;
				this.RaisePropertyChanged("Input_TargetGUIDs");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DefinitionName
		{
			get
			{
				return this.input_DefinitionNameField;
			}
			set
			{
				this.input_DefinitionNameField = value;
				this.RaisePropertyChanged("Input_DefinitionName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_NodeEffectGUID
		{
			get
			{
				return this.output_NodeEffectGUIDField;
			}
			set
			{
				this.output_NodeEffectGUIDField = value;
				this.RaisePropertyChanged("Output_NodeEffectGUID");
			}
		}
	}

}