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
	public class QuestExecutionTreeDecorator_ShipLevelUp : QuestExecutionTreeDecorator_EmpireEventOfEventShipLevelup
	{

		private QuestInputArgument input_ShipField;

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_MinimumLevelField;

		private QuestOutputArgument output_ShipField;

		private QuestOutputArgument output_ShipGUIDField;

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
		public QuestInputArgument Input_HullName
		{
			get
			{
				return this.input_HullNameField;
			}
			set
			{
				this.input_HullNameField = value;
				this.RaisePropertyChanged("Input_HullName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumLevel
		{
			get
			{
				return this.input_MinimumLevelField;
			}
			set
			{
				this.input_MinimumLevelField = value;
				this.RaisePropertyChanged("Input_MinimumLevel");
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
		public QuestOutputArgument Output_ShipGUID
		{
			get
			{
				return this.output_ShipGUIDField;
			}
			set
			{
				this.output_ShipGUIDField = value;
				this.RaisePropertyChanged("Output_ShipGUID");
			}
		}
	}

}