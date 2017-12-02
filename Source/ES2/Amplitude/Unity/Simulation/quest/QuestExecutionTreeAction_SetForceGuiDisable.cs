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
	public class QuestExecutionTreeAction_SetForceGuiDisable : QuestExecutionTreeAction
	{

		private string keyField;

		private bool forceDisableField;

		public QuestExecutionTreeAction_SetForceGuiDisable()
		{
			this.keyField = "";
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string Key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
				this.RaisePropertyChanged("Key");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public bool ForceDisable
		{
			get
			{
				return this.forceDisableField;
			}
			set
			{
				this.forceDisableField = value;
				this.RaisePropertyChanged("ForceDisable");
			}
		}
	}

}