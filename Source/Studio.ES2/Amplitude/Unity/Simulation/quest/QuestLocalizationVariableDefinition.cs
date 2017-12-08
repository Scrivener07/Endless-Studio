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
	public class QuestLocalizationVariableDefinition : QuestVariableDefinition
	{
		private string localizationKeyField;

		private string sourceField;


		/// <remarks/>
		[XmlAttribute]
		public string LocalizationKey
		{
			get { return this.localizationKeyField; }
			set
			{
				this.localizationKeyField = value;
				this.RaisePropertyChanged("LocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Source
		{
			get { return this.sourceField; }
			set
			{
				this.sourceField = value;
				this.RaisePropertyChanged("Source");
			}
		}


	}
}
