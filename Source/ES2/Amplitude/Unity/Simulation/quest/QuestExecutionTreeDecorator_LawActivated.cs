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
	public class QuestExecutionTreeDecorator_LawActivated : QuestExecutionTreeDecorator_EmpireEventOfEventLawActivated
	{

		private QuestInputArgument input_PoliticsField;

		private QuestInputArgument input_RequiredSupportField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Politics
		{
			get
			{
				return this.input_PoliticsField;
			}
			set
			{
				this.input_PoliticsField = value;
				this.RaisePropertyChanged("Input_Politics");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_RequiredSupport
		{
			get
			{
				return this.input_RequiredSupportField;
			}
			set
			{
				this.input_RequiredSupportField = value;
				this.RaisePropertyChanged("Input_RequiredSupport");
			}
		}
	}

}