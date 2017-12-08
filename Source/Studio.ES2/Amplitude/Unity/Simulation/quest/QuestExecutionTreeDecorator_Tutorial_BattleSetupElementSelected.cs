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
	public class QuestExecutionTreeDecorator_Tutorial_BattleSetupElementSelected : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_AdvancedBattleSetupElementSelected
	{

		private ElementName elementNameField;

		public QuestExecutionTreeDecorator_Tutorial_BattleSetupElementSelected()
		{
			this.elementNameField = ElementName.None;
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(ElementName.None)]
		public ElementName ElementName
		{
			get
			{
				return this.elementNameField;
			}
			set
			{
				this.elementNameField = value;
				this.RaisePropertyChanged("ElementName");
			}
		}
	}

}