namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraShotKeyLayerTransitionDefinition_Curve))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraShotKeyLayerTransitionDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private float startTimeRatioField;

		private CameraShotKeyTransitionLayerTags layerTagsField;

		private CameraShotKeyTransitionLayerOptions layerOptionsField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float StartTimeRatio
		{
			get
			{
				return this.startTimeRatioField;
			}
			set
			{
				this.startTimeRatioField = value;
				this.RaisePropertyChanged("StartTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public CameraShotKeyTransitionLayerTags LayerTags
		{
			get
			{
				return this.layerTagsField;
			}
			set
			{
				this.layerTagsField = value;
				this.RaisePropertyChanged("LayerTags");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public CameraShotKeyTransitionLayerOptions LayerOptions
		{
			get
			{
				return this.layerOptionsField;
			}
			set
			{
				this.layerOptionsField = value;
				this.RaisePropertyChanged("LayerOptions");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
