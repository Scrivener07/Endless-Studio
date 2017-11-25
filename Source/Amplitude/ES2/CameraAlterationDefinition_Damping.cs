namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition_Damping : CameraAlterationDefinition
	{

		private float dampingDurationField;

		private float amplificationEndTimeRatioField;

		private float reductionStartTimeRatioField;

		public CameraAlterationDefinition_Damping()
		{
			this.amplificationEndTimeRatioField = ((float)(0F));
			this.reductionStartTimeRatioField = ((float)(1F));
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float DampingDuration
		{
			get
			{
				return this.dampingDurationField;
			}
			set
			{
				this.dampingDurationField = value;
				this.RaisePropertyChanged("DampingDuration");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float AmplificationEndTimeRatio
		{
			get
			{
				return this.amplificationEndTimeRatioField;
			}
			set
			{
				this.amplificationEndTimeRatioField = value;
				this.RaisePropertyChanged("AmplificationEndTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "1")]
		public float ReductionStartTimeRatio
		{
			get
			{
				return this.reductionStartTimeRatioField;
			}
			set
			{
				this.reductionStartTimeRatioField = value;
				this.RaisePropertyChanged("ReductionStartTimeRatio");
			}
		}
	}
}
