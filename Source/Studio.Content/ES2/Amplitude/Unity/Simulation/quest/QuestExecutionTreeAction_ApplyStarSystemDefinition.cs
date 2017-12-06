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
	public class QuestExecutionTreeAction_ApplyStarSystemDefinition : QuestExecutionTreeAction
	{

		private QuestInputArgument input_DefinitionNameField;

		private QuestInputArgument input_StarSystemNodeField;

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
		public QuestInputArgument Input_StarSystemNode
		{
			get
			{
				return this.input_StarSystemNodeField;
			}
			set
			{
				this.input_StarSystemNodeField = value;
				this.RaisePropertyChanged("Input_StarSystemNode");
			}
		}
	}

}