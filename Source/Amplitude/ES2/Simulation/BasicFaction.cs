using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class BasicFaction : Faction
	{
		private XmlNamedReference affinityMappingField;


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
