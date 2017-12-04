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
	public class QuestExecutionTreeDecorator_Intercept : QuestExecutionTreeDecorator_EmpireEventOfEventFleetHasInterceptedAnEnemy
	{

		private int input_CountField;

		private QuestInputArgument input_NodeField;

		private QuestInputArgument input_InterceptorFleetGUIDField;

		private QuestInputArgument input_InterceptorFleetField;

		private QuestInputArgument input_InterceptorShipField;

		private QuestInputArgument input_VictimFleetGUIDField;

		private QuestInputArgument input_VictimFleetField;

		private QuestInputArgument input_VictimShipField;

		private QuestOutputArgument output_NodeField;

		private QuestOutputArgument output_InterceptorsField;

		private QuestOutputArgument output_VictimGUIDField;

		public QuestExecutionTreeDecorator_Intercept()
		{
			this.input_CountField = 1;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		[DefaultValue(1)]
		public int Input_Count
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
		public QuestInputArgument Input_InterceptorFleetGUID
		{
			get
			{
				return this.input_InterceptorFleetGUIDField;
			}
			set
			{
				this.input_InterceptorFleetGUIDField = value;
				this.RaisePropertyChanged("Input_InterceptorFleetGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_InterceptorFleet
		{
			get
			{
				return this.input_InterceptorFleetField;
			}
			set
			{
				this.input_InterceptorFleetField = value;
				this.RaisePropertyChanged("Input_InterceptorFleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_InterceptorShip
		{
			get
			{
				return this.input_InterceptorShipField;
			}
			set
			{
				this.input_InterceptorShipField = value;
				this.RaisePropertyChanged("Input_InterceptorShip");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_VictimFleetGUID
		{
			get
			{
				return this.input_VictimFleetGUIDField;
			}
			set
			{
				this.input_VictimFleetGUIDField = value;
				this.RaisePropertyChanged("Input_VictimFleetGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_VictimFleet
		{
			get
			{
				return this.input_VictimFleetField;
			}
			set
			{
				this.input_VictimFleetField = value;
				this.RaisePropertyChanged("Input_VictimFleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_VictimShip
		{
			get
			{
				return this.input_VictimShipField;
			}
			set
			{
				this.input_VictimShipField = value;
				this.RaisePropertyChanged("Input_VictimShip");
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
		public QuestOutputArgument Output_Interceptors
		{
			get
			{
				return this.output_InterceptorsField;
			}
			set
			{
				this.output_InterceptorsField = value;
				this.RaisePropertyChanged("Output_Interceptors");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_VictimGUID
		{
			get
			{
				return this.output_VictimGUIDField;
			}
			set
			{
				this.output_VictimGUIDField = value;
				this.RaisePropertyChanged("Output_VictimGUID");
			}
		}
	}

}