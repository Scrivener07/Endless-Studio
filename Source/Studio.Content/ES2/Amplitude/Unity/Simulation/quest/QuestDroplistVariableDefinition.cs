using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestDroplistVariableDefinition : QuestVariableDefinition
	{

		private string droplistField;

		/// <remarks/>
		[XmlAttribute]
		public string Droplist
		{
			get
			{
				return this.droplistField;
			}
			set
			{
				this.droplistField = value;
				this.RaisePropertyChanged("Droplist");
			}
		}


	}
}
