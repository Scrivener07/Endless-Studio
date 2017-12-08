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
	public class QuestExecutionTreeAction_HealFleets : QuestExecutionTreeAction
	{

		private QuestInputArgument input_FleetsField;

		private QuestInputArgument input_AmountField;

		private bool includeHeroShipField;

		public QuestExecutionTreeAction_HealFleets()
		{
			this.includeHeroShipField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Fleets
		{
			get
			{
				return this.input_FleetsField;
			}
			set
			{
				this.input_FleetsField = value;
				this.RaisePropertyChanged("Input_Fleets");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Amount
		{
			get
			{
				return this.input_AmountField;
			}
			set
			{
				this.input_AmountField = value;
				this.RaisePropertyChanged("Input_Amount");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IncludeHeroShip
		{
			get
			{
				return this.includeHeroShipField;
			}
			set
			{
				this.includeHeroShipField = value;
				this.RaisePropertyChanged("IncludeHeroShip");
			}
		}
	}

}