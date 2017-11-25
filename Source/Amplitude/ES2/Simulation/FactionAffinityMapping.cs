using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class FactionAffinityMapping : FactionTrait
	{
		private AbstractToShipDesignPair[] shipDesignField;


		[XmlElement("ShipDesign", Form = XmlSchemaForm.Unqualified)]
		public AbstractToShipDesignPair[] ShipDesign
		{
			get
			{
				return this.shipDesignField;
			}
			set
			{
				this.shipDesignField = value;
				this.RaisePropertyChanged("ShipDesign");
			}
		}


	}
}