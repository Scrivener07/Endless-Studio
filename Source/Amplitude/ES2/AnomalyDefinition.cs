namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public class AnomalyDefinition : DatatableElement
	{

		private SimulationDescriptorReference[] simulationDescriptorReferenceField;

		private SimulationDescriptorReference[] encounterGlobalEffectDescriptorReferenceField;

		private XmlNamedReference[] encounterEntityReferenceField;

		private DummyGeneratorInfo[] generatorInfoField;

		private AnomalyQuality qualityField;

		private bool indestructibleField;

		public AnomalyDefinition()
		{
			this.indestructibleField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SimulationDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] SimulationDescriptorReference
		{
			get
			{
				return this.simulationDescriptorReferenceField;
			}
			set
			{
				this.simulationDescriptorReferenceField = value;
				this.RaisePropertyChanged("SimulationDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EncounterGlobalEffectDescriptorReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationDescriptorReference[] EncounterGlobalEffectDescriptorReference
		{
			get
			{
				return this.encounterGlobalEffectDescriptorReferenceField;
			}
			set
			{
				this.encounterGlobalEffectDescriptorReferenceField = value;
				this.RaisePropertyChanged("EncounterGlobalEffectDescriptorReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EncounterEntityReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference[] EncounterEntityReference
		{
			get
			{
				return this.encounterEntityReferenceField;
			}
			set
			{
				this.encounterEntityReferenceField = value;
				this.RaisePropertyChanged("EncounterEntityReference");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("GeneratorInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DummyGeneratorInfo[] GeneratorInfo
		{
			get
			{
				return this.generatorInfoField;
			}
			set
			{
				this.generatorInfoField = value;
				this.RaisePropertyChanged("GeneratorInfo");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public AnomalyQuality Quality
		{
			get
			{
				return this.qualityField;
			}
			set
			{
				this.qualityField = value;
				this.RaisePropertyChanged("Quality");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Indestructible
		{
			get
			{
				return this.indestructibleField;
			}
			set
			{
				this.indestructibleField = value;
				this.RaisePropertyChanged("Indestructible");
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	public enum AnomalyQuality
	{

		/// <remarks/>
		Negative,

		/// <remarks/>
		Mixed,

		/// <remarks/>
		Positive,

		/// <remarks/>
		Reduced,

		/// <remarks/>
		Moon,
	}
}
