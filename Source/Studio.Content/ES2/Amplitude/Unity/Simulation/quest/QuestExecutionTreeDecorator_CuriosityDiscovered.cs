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
	public class QuestExecutionTreeDecorator_CuriosityDiscovered : QuestExecutionTreeDecorator_EmpireEventOfEventCuriosityDiscovered
	{

		private QuestInputArgument input_CuriosityNameField;

		private QuestInputArgument input_DisplayedTypeField;

		private QuestInputArgument input_CuriosityGUIDsField;

		private QuestOutputArgument output_PlanetField;

		private QuestOutputArgument output_NodeField;

		private QuestOutputArgument output_FleetGUIDField;

		private bool onlyAllowDiscoveryByFleetField;

		public QuestExecutionTreeDecorator_CuriosityDiscovered()
		{
			this.onlyAllowDiscoveryByFleetField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_CuriosityName
		{
			get
			{
				return this.input_CuriosityNameField;
			}
			set
			{
				this.input_CuriosityNameField = value;
				this.RaisePropertyChanged("Input_CuriosityName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_DisplayedType
		{
			get
			{
				return this.input_DisplayedTypeField;
			}
			set
			{
				this.input_DisplayedTypeField = value;
				this.RaisePropertyChanged("Input_DisplayedType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_CuriosityGUIDs
		{
			get
			{
				return this.input_CuriosityGUIDsField;
			}
			set
			{
				this.input_CuriosityGUIDsField = value;
				this.RaisePropertyChanged("Input_CuriosityGUIDs");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Planet
		{
			get
			{
				return this.output_PlanetField;
			}
			set
			{
				this.output_PlanetField = value;
				this.RaisePropertyChanged("Output_Planet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Node
		{
			get
			{
				return this.output_NodeField;
			}
			set
			{
				this.output_NodeField = value;
				this.RaisePropertyChanged("Output_Node");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_FleetGUID
		{
			get
			{
				return this.output_FleetGUIDField;
			}
			set
			{
				this.output_FleetGUIDField = value;
				this.RaisePropertyChanged("Output_FleetGUID");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool OnlyAllowDiscoveryByFleet
		{
			get
			{
				return this.onlyAllowDiscoveryByFleetField;
			}
			set
			{
				this.onlyAllowDiscoveryByFleetField = value;
				this.RaisePropertyChanged("OnlyAllowDiscoveryByFleet");
			}
		}
	}

}