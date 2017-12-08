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
	public class QuestExecutionTreeAction_ApplyDescriptor : QuestExecutionTreeAction
	{

		private QuestInputArgument input_DescriptorNameField;

		private QuestInputArgument input_TargetsField;

		private QuestInputArgument input_TargetGUIDsField;

		private bool removeField;

		public QuestExecutionTreeAction_ApplyDescriptor()
		{
			this.removeField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DescriptorName
		{
			get
			{
				return this.input_DescriptorNameField;
			}
			set
			{
				this.input_DescriptorNameField = value;
				this.RaisePropertyChanged("Input_DescriptorName");
			}
		}

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
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Remove
		{
			get
			{
				return this.removeField;
			}
			set
			{
				this.removeField = value;
				this.RaisePropertyChanged("Remove");
			}
		}
	}

}