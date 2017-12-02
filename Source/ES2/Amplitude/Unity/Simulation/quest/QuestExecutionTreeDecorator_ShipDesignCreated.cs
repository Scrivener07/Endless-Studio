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
	public class QuestExecutionTreeDecorator_ShipDesignCreated : QuestExecutionTreeDecoratorOfEventShipDesignCreated
	{

		private QuestInputArgument input_HullNameField;

		private QuestInputArgument input_ModuleNameField;

		private QuestInputArgument input_ModuleTypeField;

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
		public QuestInputArgument Input_ModuleType
		{
			get
			{
				return this.input_ModuleTypeField;
			}
			set
			{
				this.input_ModuleTypeField = value;
				this.RaisePropertyChanged("Input_ModuleType");
			}
		}
	}

}