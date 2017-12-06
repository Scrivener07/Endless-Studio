using Studio.Model;
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
	public class StartingPopulation : EntityTypeComplex
	{
		private string affinityField;

		private int countField;


		/// <remarks/>
		[XmlAttribute]
		public string Affinity
		{
			get { return this.affinityField; }
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public int Count
		{
			get { return this.countField; }
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}





	}
}
