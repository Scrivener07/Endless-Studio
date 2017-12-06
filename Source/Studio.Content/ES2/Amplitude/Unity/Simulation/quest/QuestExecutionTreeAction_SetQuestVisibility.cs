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
	public class QuestExecutionTreeAction_SetQuestVisibility : QuestExecutionTreeAction
	{

		private bool visibleField;

		/// <remarks/>
		[XmlAttribute]
		public bool Visible
		{
			get
			{
				return this.visibleField;
			}
			set
			{
				this.visibleField = value;
				this.RaisePropertyChanged("Visible");
			}
		}
	}

}