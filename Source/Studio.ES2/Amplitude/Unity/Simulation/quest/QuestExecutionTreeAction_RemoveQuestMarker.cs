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
	public class QuestExecutionTreeAction_RemoveQuestMarker : QuestExecutionTreeAction
	{

		private QuestInputArgument input_MarkersField;

		private QuestInputArgument input_TargetsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Markers
		{
			get
			{
				return this.input_MarkersField;
			}
			set
			{
				this.input_MarkersField = value;
				this.RaisePropertyChanged("Input_Markers");
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
	}

}