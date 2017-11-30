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
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class FactionPopulationTrait : FactionTrait
	{

		private XmlNamedReference[] majorPopulationDescriptorsField;

		private XmlNamedReference[] nonMajorPopulationDescriptorsField;

		private XmlNamedReference[] majorPopulationAspirationsField;

		private XmlNamedReference[] nonMajorPopulationsAspirationsField;


		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationDescriptors
		{
			get { return this.majorPopulationDescriptorsField; }
			set
			{
				this.majorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("MajorPopulationDescriptors");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationDescriptors
		{
			get { return this.nonMajorPopulationDescriptorsField; }
			set
			{
				this.nonMajorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("NonMajorPopulationDescriptors");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("AspirationReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationAspirations
		{
			get { return this.majorPopulationAspirationsField; }
			set
			{
				this.majorPopulationAspirationsField = value;
				this.RaisePropertyChanged("MajorPopulationAspirations");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("AspirationReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationsAspirations
		{
			get { return this.nonMajorPopulationsAspirationsField; }
			set
			{
				this.nonMajorPopulationsAspirationsField = value;
				this.RaisePropertyChanged("NonMajorPopulationsAspirations");
			}
		}


	}
}
