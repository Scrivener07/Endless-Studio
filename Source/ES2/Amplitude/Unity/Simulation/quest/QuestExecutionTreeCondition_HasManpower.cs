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
	public class QuestExecutionTreeCondition_HasManpower : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_LocationField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MaximumAmountField;

		private QuestInputArgument input_MinimumNumberOfValidLocationsField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Location
		{
			get
			{
				return this.input_LocationField;
			}
			set
			{
				this.input_LocationField = value;
				this.RaisePropertyChanged("Input_Location");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumAmount
		{
			get
			{
				return this.input_MinimumAmountField;
			}
			set
			{
				this.input_MinimumAmountField = value;
				this.RaisePropertyChanged("Input_MinimumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumAmount
		{
			get
			{
				return this.input_MaximumAmountField;
			}
			set
			{
				this.input_MaximumAmountField = value;
				this.RaisePropertyChanged("Input_MaximumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumNumberOfValidLocations
		{
			get
			{
				return this.input_MinimumNumberOfValidLocationsField;
			}
			set
			{
				this.input_MinimumNumberOfValidLocationsField = value;
				this.RaisePropertyChanged("Input_MinimumNumberOfValidLocations");
			}
		}
	}

}