namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Shot_EncounterEvent))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Shot : DatatableElement
	{

		private CameraShotKeyDefinition[] keyField;

		private CameraAlterationDefinition[] itemsField;

		private double durationField;

		private float lateStartTimeRatioField;

		private float earlyEndTimeRatioField;

		private float lateEndTimeRatioField;

		public Shot()
		{
			this.lateStartTimeRatioField = ((float)(0F));
			this.earlyEndTimeRatioField = ((float)(1F));
			this.lateEndTimeRatioField = ((float)(1F));
		}


		[System.Xml.Serialization.XmlElementAttribute("Key", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraShotKeyDefinition[] Key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
				this.RaisePropertyChanged("Key");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("AlterationAudio", typeof(CameraAlterationDefinition_Audio), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AlterationDamping", typeof(CameraAlterationDefinition_Damping), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AlterationEvent", typeof(CameraAlterationDefinition_Event), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AlterationFocus", typeof(CameraAlterationDefinition_Focus), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AlterationPlanetDestruction", typeof(CameraAlterationDefinition_PlanetDestruction), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AlterationShake", typeof(CameraAlterationDefinition_Shake), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraAlterationDefinition[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("Duration");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float LateStartTimeRatio
		{
			get
			{
				return this.lateStartTimeRatioField;
			}
			set
			{
				this.lateStartTimeRatioField = value;
				this.RaisePropertyChanged("LateStartTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float EarlyEndTimeRatio
		{
			get
			{
				return this.earlyEndTimeRatioField;
			}
			set
			{
				this.earlyEndTimeRatioField = value;
				this.RaisePropertyChanged("EarlyEndTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float LateEndTimeRatio
		{
			get
			{
				return this.lateEndTimeRatioField;
			}
			set
			{
				this.lateEndTimeRatioField = value;
				this.RaisePropertyChanged("LateEndTimeRatio");
			}
		}
	}
}
