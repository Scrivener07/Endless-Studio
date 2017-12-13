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
	[XmlRoot("FactionAffinity", Namespace = "", IsNullable = true)]
	public class FactionAffinity : FactionTrait
	{
		private string defaultColonizerField;

		private string automatedShipField;

		private string unlockedAbstractShipDesignsField;

		private string startingFleetsField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string DefaultColonizer
		{
			get { return this.defaultColonizerField; }
			set
			{
				this.defaultColonizerField = value;
				this.RaisePropertyChanged("DefaultColonizer");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string AutomatedShip
		{
			get { return this.automatedShipField; }
			set
			{
				this.automatedShipField = value;
				this.RaisePropertyChanged("AutomatedShip");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string UnlockedAbstractShipDesigns
		{
			get { return this.unlockedAbstractShipDesignsField; }
			set
			{
				this.unlockedAbstractShipDesignsField = value;
				this.RaisePropertyChanged("UnlockedAbstractShipDesigns");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string StartingFleets
		{
			get { return this.startingFleetsField; }
			set
			{
				this.startingFleetsField = value;
				this.RaisePropertyChanged("StartingFleets");
			}
		}


	}
}
