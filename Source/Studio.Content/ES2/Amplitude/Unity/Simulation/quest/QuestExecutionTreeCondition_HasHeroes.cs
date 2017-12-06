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
	public class QuestExecutionTreeCondition_HasHeroes : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MinimumLevelField;

		private QuestInputArgument input_LocationsField;

		private QuestInputArgument input_LocationGUIDsField;

		private HeroAssignationFilter heroAssignationFilterField;

		public QuestExecutionTreeCondition_HasHeroes()
		{
			this.heroAssignationFilterField = HeroAssignationFilter.DontCare;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empire
		{
			get
			{
				return this.input_EmpireField;
			}
			set
			{
				this.input_EmpireField = value;
				this.RaisePropertyChanged("Input_Empire");
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
		public QuestInputArgument Input_Locations
		{
			get
			{
				return this.input_LocationsField;
			}
			set
			{
				this.input_LocationsField = value;
				this.RaisePropertyChanged("Input_Locations");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_LocationGUIDs
		{
			get
			{
				return this.input_LocationGUIDsField;
			}
			set
			{
				this.input_LocationGUIDsField = value;
				this.RaisePropertyChanged("Input_LocationGUIDs");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(HeroAssignationFilter.DontCare)]
		public HeroAssignationFilter HeroAssignationFilter
		{
			get
			{
				return this.heroAssignationFilterField;
			}
			set
			{
				this.heroAssignationFilterField = value;
				this.RaisePropertyChanged("HeroAssignationFilter");
			}
		}
	}

}