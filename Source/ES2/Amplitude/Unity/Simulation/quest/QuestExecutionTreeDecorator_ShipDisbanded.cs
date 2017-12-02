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
	public class QuestExecutionTreeDecorator_ShipDisbanded : QuestExecutionTreeDecoratorOfEventShipDisbanded
	{

		private QuestInputArgument input_HangarsField;

		private QuestInputArgument input_ShipGUIDField;

		private QuestInputArgument input_FleetGUIDField;

		private QuestInputArgument input_ShipsInHangarsCountField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_ModuleCategoryField;

		private QuestOutputArgument output_ShipField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Hangars
		{
			get
			{
				return this.input_HangarsField;
			}
			set
			{
				this.input_HangarsField = value;
				this.RaisePropertyChanged("Input_Hangars");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ShipGUID
		{
			get
			{
				return this.input_ShipGUIDField;
			}
			set
			{
				this.input_ShipGUIDField = value;
				this.RaisePropertyChanged("Input_ShipGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_FleetGUID
		{
			get
			{
				return this.input_FleetGUIDField;
			}
			set
			{
				this.input_FleetGUIDField = value;
				this.RaisePropertyChanged("Input_FleetGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ShipsInHangarsCount
		{
			get
			{
				return this.input_ShipsInHangarsCountField;
			}
			set
			{
				this.input_ShipsInHangarsCountField = value;
				this.RaisePropertyChanged("Input_ShipsInHangarsCount");
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
	}

}