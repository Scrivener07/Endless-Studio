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
	public class QuestExecutionTreeDecorator_ShipDestroyed : QuestExecutionTreeDecoratorOfEventShipDestroyed
	{

		private QuestInputArgument input_OwnerEmpireField;

		private QuestInputArgument input_ShipGUIDField;

		private QuestInputArgument input_ShipField;

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_ShipDesignNameField;

		private QuestInputArgument input_RoleNameField;

		private QuestOutputArgument output_NodeField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_OwnerEmpire
		{
			get
			{
				return this.input_OwnerEmpireField;
			}
			set
			{
				this.input_OwnerEmpireField = value;
				this.RaisePropertyChanged("Input_OwnerEmpire");
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
		public QuestInputArgument Input_ShipDesignName
		{
			get
			{
				return this.input_ShipDesignNameField;
			}
			set
			{
				this.input_ShipDesignNameField = value;
				this.RaisePropertyChanged("Input_ShipDesignName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_RoleName
		{
			get
			{
				return this.input_RoleNameField;
			}
			set
			{
				this.input_RoleNameField = value;
				this.RaisePropertyChanged("Input_RoleName");
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
	}

}