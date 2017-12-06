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
	public class QuestExecutionTreeAction_SpawnCuriosity : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_PlanetsField;

		private QuestInputArgument input_CountField;

		private QuestInputArgument input_CuriosityDefinitionField;

		private QuestOutputArgument output_CuriosityGUIDsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empires
		{
			get
			{
				return this.input_EmpiresField;
			}
			set
			{
				this.input_EmpiresField = value;
				this.RaisePropertyChanged("Input_Empires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Planets
		{
			get
			{
				return this.input_PlanetsField;
			}
			set
			{
				this.input_PlanetsField = value;
				this.RaisePropertyChanged("Input_Planets");
			}
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
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_CuriosityDefinition
		{
			get
			{
				return this.input_CuriosityDefinitionField;
			}
			set
			{
				this.input_CuriosityDefinitionField = value;
				this.RaisePropertyChanged("Input_CuriosityDefinition");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_CuriosityGUIDs
		{
			get
			{
				return this.output_CuriosityGUIDsField;
			}
			set
			{
				this.output_CuriosityGUIDsField = value;
				this.RaisePropertyChanged("Output_CuriosityGUIDs");
			}
		}
	}

}