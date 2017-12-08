using ES2.Amplitude.Unity.Xml;
using ES2.Editor.Framework;
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
	public class MinorFaction : Faction
	{

		private XmlNamedReference personalityField;

		private XmlNamedReference politicsField;

		private ObservableListSource<ColonizablePlanetType> colonizablePlanetField;


		public MinorFaction() : base()
		{
			personalityField = new XmlNamedReference();
			politicsField = new XmlNamedReference();
			colonizablePlanetField = new ObservableListSource<ColonizablePlanetType>();
		}


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference Personality
		{
			get { return this.personalityField; }
			set
			{
				this.personalityField = value;
				this.RaisePropertyChanged("Personality");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference Politics
		{
			get { return this.politicsField; }
			set
			{
				this.politicsField = value;
				this.RaisePropertyChanged("Politics");
			}
		}

		/// <remarks/>
		[XmlElement("ColonizablePlanet", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<ColonizablePlanetType> ColonizablePlanet
		{
			get { return this.colonizablePlanetField; }
			set
			{
				this.colonizablePlanetField = value;
				this.RaisePropertyChanged("ColonizablePlanet");
			}
		}


	}
}
