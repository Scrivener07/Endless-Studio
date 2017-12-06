using ES2.Amplitude.Unity.Xml;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class BasicFaction : Faction
	{

		private XmlNamedReference affinityMappingField;


		public BasicFaction() : base()
		{
			affinityMappingField = new XmlNamedReference();
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference AffinityMapping
		{
			get { return this.affinityMappingField; }
			set
			{
				this.affinityMappingField = value;
				this.RaisePropertyChanged("AffinityMapping");
			}
		}


	}
}
