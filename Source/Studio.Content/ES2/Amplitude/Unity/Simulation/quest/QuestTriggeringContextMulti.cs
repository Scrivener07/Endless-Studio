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
	public class QuestTriggeringContextMulti : QuestTriggeringContextSolo
	{

		private EmpireDistribution distributionField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public EmpireDistribution Distribution
		{
			get { return this.distributionField; }
			set
			{
				this.distributionField = value;
				this.RaisePropertyChanged("Distribution");
			}
		}


	}
}
