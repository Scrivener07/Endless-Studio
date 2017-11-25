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
	public partial class FactionPopulationTrait : FactionTrait
	{
		private XmlNamedReference[] majorPopulationDescriptorsField;
		private XmlNamedReference[] nonMajorPopulationDescriptorsField;
		private XmlNamedReference[] majorPopulationAspirationsField;
		private XmlNamedReference[] nonMajorPopulationsAspirationsField;


		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationDescriptors
		{
			get
			{
				return this.majorPopulationDescriptorsField;
			}
			set
			{
				this.majorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("MajorPopulationDescriptors");
			}
		}


		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationDescriptors
		{
			get
			{
				return this.nonMajorPopulationDescriptorsField;
			}
			set
			{
				this.nonMajorPopulationDescriptorsField = value;
				this.RaisePropertyChanged("NonMajorPopulationDescriptors");
			}
		}


		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("AspirationReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] MajorPopulationAspirations
		{
			get
			{
				return this.majorPopulationAspirationsField;
			}
			set
			{
				this.majorPopulationAspirationsField = value;
				this.RaisePropertyChanged("MajorPopulationAspirations");
			}
		}


		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("AspirationReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlNamedReference[] NonMajorPopulationsAspirations
		{
			get
			{
				return this.nonMajorPopulationsAspirationsField;
			}
			set
			{
				this.nonMajorPopulationsAspirationsField = value;
				this.RaisePropertyChanged("NonMajorPopulationsAspirations");
			}
		}


	}
}
