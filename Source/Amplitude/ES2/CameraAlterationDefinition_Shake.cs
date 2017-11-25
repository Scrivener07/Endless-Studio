namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition_Shake : CameraAlterationDefinition
	{

		private float amplitudeMinField;

		private float amplitudeMaxField;

		private float smoothnessField;

		private float frequencyMinField;

		private float frequencyMaxField;

		public CameraAlterationDefinition_Shake()
		{
			this.amplitudeMinField = ((float)(0F));
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float AmplitudeMin
		{
			get
			{
				return this.amplitudeMinField;
			}
			set
			{
				this.amplitudeMinField = value;
				this.RaisePropertyChanged("AmplitudeMin");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float AmplitudeMax
		{
			get
			{
				return this.amplitudeMaxField;
			}
			set
			{
				this.amplitudeMaxField = value;
				this.RaisePropertyChanged("AmplitudeMax");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Smoothness
		{
			get
			{
				return this.smoothnessField;
			}
			set
			{
				this.smoothnessField = value;
				this.RaisePropertyChanged("Smoothness");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float FrequencyMin
		{
			get
			{
				return this.frequencyMinField;
			}
			set
			{
				this.frequencyMinField = value;
				this.RaisePropertyChanged("FrequencyMin");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float FrequencyMax
		{
			get
			{
				return this.frequencyMaxField;
			}
			set
			{
				this.frequencyMaxField = value;
				this.RaisePropertyChanged("FrequencyMax");
			}
		}
	}
}
