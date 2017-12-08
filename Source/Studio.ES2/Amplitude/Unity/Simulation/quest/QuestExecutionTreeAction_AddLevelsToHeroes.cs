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
	public class QuestExecutionTreeAction_AddLevelsToHeroes : QuestExecutionTreeAction
	{
		private QuestInputArgument input_HeroesField;

		private QuestInputArgument input_HeroGUIDsField;

		private QuestInputArgument input_AmountField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Heroes
		{
			get
			{
				return this.input_HeroesField;
			}
			set
			{
				this.input_HeroesField = value;
				this.RaisePropertyChanged("Input_Heroes");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroGUIDs
		{
			get
			{
				return this.input_HeroGUIDsField;
			}
			set
			{
				this.input_HeroGUIDsField = value;
				this.RaisePropertyChanged("Input_HeroGUIDs");
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


	}
}