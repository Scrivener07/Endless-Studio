using ES2.Editor.Model;
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
	public class PoliticsWeight : EntityTypeComplex
	{
		private string politicsField;

		private float weightField;


		/// <remarks/>
		[XmlAttribute]
		public string Politics
		{
			get { return this.politicsField; }
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public float Weight
		{
			get { return this.weightField; }
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}


	}
}
