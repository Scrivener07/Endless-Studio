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
	public class QuestExecutionTreeDecorator_ShipConstructed : QuestExecutionTreeDecoratorOfEventShipConstructed
	{

		private QuestInputArgument input_NodeField;

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_ShipDesignNameField;

		private QuestInputArgument input_RoleNameField;

		private QuestInputArgument input_RequiredTagField;

		private QuestOutputArgument output_ShipField;

		private QuestOutputArgument output_NodeField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Node
		{
			get
			{
				return this.input_NodeField;
			}
			set
			{
				this.input_NodeField = value;
				this.RaisePropertyChanged("Input_Node");
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
		public QuestInputArgument Input_RequiredTag
		{
			get
			{
				return this.input_RequiredTagField;
			}
			set
			{
				this.input_RequiredTagField = value;
				this.RaisePropertyChanged("Input_RequiredTag");
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