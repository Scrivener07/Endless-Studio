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
	public class QuestExecutionTreeAction_AddQuestMarker : QuestExecutionTreeAction
	{

		private QuestInputArgument input_TargetsField;

		private QuestInputArgument input_TargetGUIDsField;

		private QuestInputArgument input_EmpiresField;

		private QuestOutputArgument output_MarkersField;

		private string markerTypeField;

		private bool revealsLocationField;

		public QuestExecutionTreeAction_AddQuestMarker()
		{
			this.markerTypeField = "Default";
			this.revealsLocationField = false;
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
		public QuestOutputArgument Output_Markers
		{
			get
			{
				return this.output_MarkersField;
			}
			set
			{
				this.output_MarkersField = value;
				this.RaisePropertyChanged("Output_Markers");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("Default")]
		public string MarkerType
		{
			get
			{
				return this.markerTypeField;
			}
			set
			{
				this.markerTypeField = value;
				this.RaisePropertyChanged("MarkerType");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool RevealsLocation
		{
			get
			{
				return this.revealsLocationField;
			}
			set
			{
				this.revealsLocationField = value;
				this.RaisePropertyChanged("RevealsLocation");
			}
		}
	}

}