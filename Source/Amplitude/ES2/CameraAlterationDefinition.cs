namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_Shake))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_Damping))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_Focus))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_Audio))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_Event))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraAlterationDefinition_PlanetDestruction))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private float startTimeRatioField;

		private float endTimeRatioField;

		private int priorityField;

		private bool timeRatiosBasedOnTheoreticalDurationField;

		public CameraAlterationDefinition()
		{
			this.priorityField = 0;
			this.timeRatiosBasedOnTheoreticalDurationField = false;
		}


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
		public float EndTimeRatio
		{
			get
			{
				return this.endTimeRatioField;
			}
			set
			{
				this.endTimeRatioField = value;
				this.RaisePropertyChanged("EndTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool TimeRatiosBasedOnTheoreticalDuration
		{
			get
			{
				return this.timeRatiosBasedOnTheoreticalDurationField;
			}
			set
			{
				this.timeRatiosBasedOnTheoreticalDurationField = value;
				this.RaisePropertyChanged("TimeRatiosBasedOnTheoreticalDuration");
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
