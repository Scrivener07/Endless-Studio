using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Xml.Schema;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class FactionAffinity : FactionTrait
	{
		private string defaultColonizerField;
		private string automatedShipField;
		private string unlockedAbstractShipDesignsField;
		private string startingFleetsField;


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