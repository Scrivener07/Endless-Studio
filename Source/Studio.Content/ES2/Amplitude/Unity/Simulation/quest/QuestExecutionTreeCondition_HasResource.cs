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
	public class QuestExecutionTreeCondition_HasResource : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_LocationField;

		private QuestInputArgument input_ResourceNameField;

		private QuestInputArgument input_MinimumField;

		private QuestInputArgument input_MaximumField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Location
		{
			get
			{
				return this.input_LocationField;
			}
			set
			{
				this.input_LocationField = value;
				this.RaisePropertyChanged("Input_Location");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ResourceName
		{
			get
			{
				return this.input_ResourceNameField;
			}
			set
			{
				this.input_ResourceNameField = value;
				this.RaisePropertyChanged("Input_ResourceName");
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
		public QuestInputArgument Input_Maximum
		{
			get
			{
				return this.input_MaximumField;
			}
			set
			{
				this.input_MaximumField = value;
				this.RaisePropertyChanged("Input_Maximum");
			}
		}
	}

}