using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Diagnostics;
using System.CodeDom.Compiler;

namespace Amplitude.ES2.Simulation
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


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DefaultColonizer
		{
			get
			{
				return this.defaultColonizerField;
			}
			set
			{
				this.defaultColonizerField = value;
				this.RaisePropertyChanged("DefaultColonizer");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AutomatedShip
		{
			get
			{
				return this.automatedShipField;
			}
			set
			{
				this.automatedShipField = value;
				this.RaisePropertyChanged("AutomatedShip");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UnlockedAbstractShipDesigns
		{
			get
			{
				return this.unlockedAbstractShipDesignsField;
			}
			set
			{
				this.unlockedAbstractShipDesignsField = value;
				this.RaisePropertyChanged("UnlockedAbstractShipDesigns");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string StartingFleets
		{
			get
			{
				return this.startingFleetsField;
			}
			set
			{
				this.startingFleetsField = value;
				this.RaisePropertyChanged("StartingFleets");
			}
		}
	}

}