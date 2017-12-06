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
	public class QuestExecutionTreeDecorator_TutorialPageOpened : QuestExecutionTreeDecorator_EmpireEventOfEventTutorialPageOpened
	{

		private string tutorialField;

		private int pageField;

		public QuestExecutionTreeDecorator_TutorialPageOpened()
		{
			this.pageField = 0;
		}

		/// <remarks/>
		[XmlAttribute]
		public string Tutorial
		{
			get
			{
				return this.tutorialField;
			}
			set
			{
				this.tutorialField = value;
				this.RaisePropertyChanged("Tutorial");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
				this.RaisePropertyChanged("Page");
			}
		}
	}

}