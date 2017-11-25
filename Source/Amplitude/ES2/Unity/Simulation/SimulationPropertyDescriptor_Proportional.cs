namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SimulationPropertyDescriptor_Proportional : SimulationPropertyDescriptor
	{

		private string maximumField;

		private string minimumField;

		private float startingRatioField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Maximum
		{
			get
			{
				return this.maximumField;
			}
			set
			{
				this.maximumField = value;
				this.RaisePropertyChanged("Maximum");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Minimum
		{
			get
			{
				return this.minimumField;
			}
			set
			{
				this.minimumField = value;
				this.RaisePropertyChanged("Minimum");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float StartingRatio
		{
			get
			{
				return this.startingRatioField;
			}
			set
			{
				this.startingRatioField = value;
				this.RaisePropertyChanged("StartingRatio");
			}
		}
	}
}
