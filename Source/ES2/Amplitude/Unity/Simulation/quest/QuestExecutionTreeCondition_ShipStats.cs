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
	public class QuestExecutionTreeCondition_ShipStats : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_ShipListField;

		private QuestInputArgument input_EmpireField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MinimumOffensiveMilitaryPowerField;

		private QuestInputArgument input_MinimumDefensiveMilitaryPowerField;

		private bool includeHeroShipsField;

		public QuestExecutionTreeCondition_ShipStats()
		{
			this.includeHeroShipsField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ShipList
		{
			get
			{
				return this.input_ShipListField;
			}
			set
			{
				this.input_ShipListField = value;
				this.RaisePropertyChanged("Input_ShipList");
			}
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
		public QuestInputArgument Input_MinimumOffensiveMilitaryPower
		{
			get
			{
				return this.input_MinimumOffensiveMilitaryPowerField;
			}
			set
			{
				this.input_MinimumOffensiveMilitaryPowerField = value;
				this.RaisePropertyChanged("Input_MinimumOffensiveMilitaryPower");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumDefensiveMilitaryPower
		{
			get
			{
				return this.input_MinimumDefensiveMilitaryPowerField;
			}
			set
			{
				this.input_MinimumDefensiveMilitaryPowerField = value;
				this.RaisePropertyChanged("Input_MinimumDefensiveMilitaryPower");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IncludeHeroShips
		{
			get
			{
				return this.includeHeroShipsField;
			}
			set
			{
				this.includeHeroShipsField = value;
				this.RaisePropertyChanged("IncludeHeroShips");
			}
		}
	}

}