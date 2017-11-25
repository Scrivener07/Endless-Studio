namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class StartingPopulation : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string affinityField;

		private int countField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Affinity
		{
			get
			{
				return this.affinityField;
			}
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
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
