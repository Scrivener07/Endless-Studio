namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class AvailableRange : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string rangeNameField;

		private float penaltyField;

		private string penaltyPropertyNameField;

		public AvailableRange()
		{
			this.penaltyField = ((float)(0F));
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string RangeName
		{
			get
			{
				return this.rangeNameField;
			}
			set
			{
				this.rangeNameField = value;
				this.RaisePropertyChanged("RangeName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float Penalty
		{
			get
			{
				return this.penaltyField;
			}
			set
			{
				this.penaltyField = value;
				this.RaisePropertyChanged("Penalty");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PenaltyPropertyName
		{
			get
			{
				return this.penaltyPropertyNameField;
			}
			set
			{
				this.penaltyPropertyNameField = value;
				this.RaisePropertyChanged("PenaltyPropertyName");
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
