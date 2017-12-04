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
	public class QuestExecutionTreeDecorator_BeginTurn : QuestExecutionTreeDecoratorOfEventBeginTurn
	{

		private bool allowOnQuestStartField;

		public QuestExecutionTreeDecorator_BeginTurn()
		{
			this.allowOnQuestStartField = false;
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool AllowOnQuestStart
		{
			get
			{
				return this.allowOnQuestStartField;
			}
			set
			{
				this.allowOnQuestStartField = value;
				this.RaisePropertyChanged("AllowOnQuestStart");
			}
		}
	}

}