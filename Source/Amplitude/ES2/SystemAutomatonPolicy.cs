namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SystemAutomatonPolicy : object, System.ComponentModel.INotifyPropertyChanged
	{

		private bool canQueueConstructionsField;

		private bool canMovePopulationsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CanQueueConstructions
		{
			get
			{
				return this.canQueueConstructionsField;
			}
			set
			{
				this.canQueueConstructionsField = value;
				this.RaisePropertyChanged("CanQueueConstructions");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CanMovePopulations
		{
			get
			{
				return this.canMovePopulationsField;
			}
			set
			{
				this.canMovePopulationsField = value;
				this.RaisePropertyChanged("CanMovePopulations");
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
