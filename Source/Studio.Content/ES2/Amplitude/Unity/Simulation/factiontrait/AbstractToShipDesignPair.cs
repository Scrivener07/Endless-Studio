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
	public class AbstractToShipDesignPair : EntityTypeComplex
	{
		private string abstractField;

		private string shipDesignField;


		/// <remarks/>
		[XmlAttribute]
		public string Abstract
		{
			get { return this.abstractField; }
			set
			{
				this.abstractField = value;
				this.RaisePropertyChanged("Abstract");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string ShipDesign
		{
			get { return this.shipDesignField; }
			set
			{
				this.shipDesignField = value;
				this.RaisePropertyChanged("ShipDesign");
			}
		}


	}
}
