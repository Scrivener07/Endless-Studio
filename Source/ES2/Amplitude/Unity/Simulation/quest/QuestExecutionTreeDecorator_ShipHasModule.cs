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
	public class QuestExecutionTreeDecorator_ShipHasModule : QuestExecutionTreeDecoratorOfEventShipLayoutChanged
	{

		private QuestInputArgument input_ShipField;

		private QuestInputArgument input_FleetField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_ModuleCategoryField;

		private QuestOutputArgument output_ShipField;

		private QuestOutputArgument output_FleetField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Ship
		{
			get
			{
				return this.input_ShipField;
			}
			set
			{
				this.input_ShipField = value;
				this.RaisePropertyChanged("Input_Ship");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleet
		{
			get
			{
				return this.input_FleetField;
			}
			set
			{
				this.input_FleetField = value;
				this.RaisePropertyChanged("Input_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ModuleName
		{
			get
			{
				return this.input_ModuleNameField;
			}
			set
			{
				this.input_ModuleNameField = value;
				this.RaisePropertyChanged("Input_ModuleName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ModuleCategory
		{
			get
			{
				return this.input_ModuleCategoryField;
			}
			set
			{
				this.input_ModuleCategoryField = value;
				this.RaisePropertyChanged("Input_ModuleCategory");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Ship
		{
			get
			{
				return this.output_ShipField;
			}
			set
			{
				this.output_ShipField = value;
				this.RaisePropertyChanged("Output_Ship");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Fleet
		{
			get
			{
				return this.output_FleetField;
			}
			set
			{
				this.output_FleetField = value;
				this.RaisePropertyChanged("Output_Fleet");
			}
		}
	}

}