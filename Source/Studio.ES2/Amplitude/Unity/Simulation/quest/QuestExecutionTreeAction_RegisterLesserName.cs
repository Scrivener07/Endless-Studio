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
	public class QuestExecutionTreeAction_RegisterLesserName : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EntitiesField;

		private QuestInputArgument input_GUIDsField;

		private QuestInputArgument input_NameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Entities
		{
			get
			{
				return this.input_EntitiesField;
			}
			set
			{
				this.input_EntitiesField = value;
				this.RaisePropertyChanged("Input_Entities");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_GUIDs
		{
			get
			{
				return this.input_GUIDsField;
			}
			set
			{
				this.input_GUIDsField = value;
				this.RaisePropertyChanged("Input_GUIDs");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Name
		{
			get
			{
				return this.input_NameField;
			}
			set
			{
				this.input_NameField = value;
				this.RaisePropertyChanged("Input_Name");
			}
		}
	}

}