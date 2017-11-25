using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class AbstractToShipDesignPair : INotifyPropertyChanged
	{
		private string abstractField;
		private string shipDesignField;


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


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
