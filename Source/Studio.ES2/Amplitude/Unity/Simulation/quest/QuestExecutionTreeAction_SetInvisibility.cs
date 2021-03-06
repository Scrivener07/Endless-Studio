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
	public class QuestExecutionTreeAction_SetInvisibility : QuestExecutionTreeAction
	{

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_TargetEntitiesField;

		private bool invisibleField;

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
		public QuestInputArgument Input_TargetEntities
		{
			get
			{
				return this.input_TargetEntitiesField;
			}
			set
			{
				this.input_TargetEntitiesField = value;
				this.RaisePropertyChanged("Input_TargetEntities");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public bool Invisible
		{
			get
			{
				return this.invisibleField;
			}
			set
			{
				this.invisibleField = value;
				this.RaisePropertyChanged("Invisible");
			}
		}
	}

}