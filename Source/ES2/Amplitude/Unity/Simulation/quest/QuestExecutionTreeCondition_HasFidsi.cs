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
	public class QuestExecutionTreeCondition_HasFidsi : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_LocationField;

		private QuestInputArgument input_FoodField;

		private QuestInputArgument input_IndustryField;

		private QuestInputArgument input_DustField;

		private QuestInputArgument input_ScienceField;

		private QuestInputArgument input_InfluenceField;

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
		public QuestInputArgument Input_Food
		{
			get
			{
				return this.input_FoodField;
			}
			set
			{
				this.input_FoodField = value;
				this.RaisePropertyChanged("Input_Food");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Industry
		{
			get
			{
				return this.input_IndustryField;
			}
			set
			{
				this.input_IndustryField = value;
				this.RaisePropertyChanged("Input_Industry");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Dust
		{
			get
			{
				return this.input_DustField;
			}
			set
			{
				this.input_DustField = value;
				this.RaisePropertyChanged("Input_Dust");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Science
		{
			get
			{
				return this.input_ScienceField;
			}
			set
			{
				this.input_ScienceField = value;
				this.RaisePropertyChanged("Input_Science");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Influence
		{
			get
			{
				return this.input_InfluenceField;
			}
			set
			{
				this.input_InfluenceField = value;
				this.RaisePropertyChanged("Input_Influence");
			}
		}
	}

}