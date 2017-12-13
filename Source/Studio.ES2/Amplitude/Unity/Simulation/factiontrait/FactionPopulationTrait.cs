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
	[XmlRoot("FactionPopulationTrait", Namespace = "", IsNullable = true)]
	public class FactionPopulationTrait : FactionTrait
	{
		private ObservableListSource<XmlNamedReference> majorPopulationDescriptorsField;

		private ObservableListSource<XmlNamedReference> nonMajorPopulationDescriptorsField;

		private ObservableListSource<XmlNamedReference> majorPopulationAspirationsField;

		private ObservableListSource<XmlNamedReference> nonMajorPopulationsAspirationsField;


		public FactionPopulationTrait()
		{
			majorPopulationDescriptorsField = new ObservableListSource<XmlNamedReference>();
			nonMajorPopulationDescriptorsField = new ObservableListSource<XmlNamedReference>();
			majorPopulationAspirationsField = new ObservableListSource<XmlNamedReference>();
			nonMajorPopulationsAspirationsField = new ObservableListSource<XmlNamedReference>();
		}


		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("SimulationDescriptorReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public ObservableListSource<XmlNamedReference> MajorPopulationDescriptors
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
		public ObservableListSource<XmlNamedReference> NonMajorPopulationDescriptors
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
		public ObservableListSource<XmlNamedReference> MajorPopulationAspirations
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
		public ObservableListSource<XmlNamedReference> NonMajorPopulationsAspirations
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
