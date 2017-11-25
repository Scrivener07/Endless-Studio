namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CountSimulationModifierDescriptor : SimulationModifierDescriptor
	{

		private string multiplierField;

		private string countPathField;

		public CountSimulationModifierDescriptor()
		{
			this.multiplierField = "1";
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("1")]
		public string Multiplier
		{
			get
			{
				return this.multiplierField;
			}
			set
			{
				this.multiplierField = value;
				this.RaisePropertyChanged("Multiplier");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CountPath
		{
			get
			{
				return this.countPathField;
			}
			set
			{
				this.countPathField = value;
				this.RaisePropertyChanged("CountPath");
			}
		}
	}
}
