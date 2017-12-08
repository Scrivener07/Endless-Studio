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
	public class FactionTraitStartingSenate : FactionTrait
	{
		private XmlNamedReference governmentField;

		private ObservableListSource<PoliticsWeight> politicsWeightField;

		private int priorityField;


		public FactionTraitStartingSenate()
		{
			governmentField = new XmlNamedReference();
			politicsWeightField = new ObservableListSource<PoliticsWeight>();
			this.priorityField = 0;
		}


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlNamedReference Government
		{
			get { return this.governmentField; }
			set
			{
				this.governmentField = value;
				this.RaisePropertyChanged("Government");
			}
		}

		/// <remarks/>
		[XmlElement("PoliticsWeight", Form = XmlSchemaForm.Unqualified)]
		public ObservableListSource<PoliticsWeight> PoliticsWeight
		{
			get { return this.politicsWeightField; }
			set
			{
				this.politicsWeightField = value;
				this.RaisePropertyChanged("PoliticsWeight");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Priority
		{
			get { return this.priorityField; }
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}


	}
}
