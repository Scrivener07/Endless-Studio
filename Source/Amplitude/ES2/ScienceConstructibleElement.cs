namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyStageDefinition))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ScienceConstructibleElement : ConstructibleElement
	{

		private TechnologyFlag technologyFlagsField;

		private bool autoUnlockField;

		public ScienceConstructibleElement()
		{
			this.technologyFlagsField = TechnologyFlag.None;
			this.autoUnlockField = false;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(TechnologyFlag.None)]
		public TechnologyFlag TechnologyFlags
		{
			get
			{
				return this.technologyFlagsField;
			}
			set
			{
				this.technologyFlagsField = value;
				this.RaisePropertyChanged("TechnologyFlags");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool AutoUnlock
		{
			get
			{
				return this.autoUnlockField;
			}
			set
			{
				this.autoUnlockField = value;
				this.RaisePropertyChanged("AutoUnlock");
			}
		}
	}
}
