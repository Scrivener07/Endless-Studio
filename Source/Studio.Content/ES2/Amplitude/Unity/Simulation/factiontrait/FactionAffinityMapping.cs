using Studio.Framework;
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
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class FactionAffinityMapping : FactionTrait
	{
		private ObservableListSource<AbstractToShipDesignPair> shipDesignField;


		public FactionAffinityMapping()
		{
			shipDesignField = new ObservableListSource<AbstractToShipDesignPair>();
		}


		/// <remarks/>
		[XmlElement("ShipDesign", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<AbstractToShipDesignPair> ShipDesign
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
