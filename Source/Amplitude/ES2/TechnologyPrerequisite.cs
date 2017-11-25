namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class TechnologyPrerequisite : PathValidityPrerequisite
	{

		private bool unlockHiddenField;

		public TechnologyPrerequisite()
		{
			this.unlockHiddenField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool UnlockHidden
		{
			get
			{
				return this.unlockHiddenField;
			}
			set
			{
				this.unlockHiddenField = value;
				this.RaisePropertyChanged("UnlockHidden");
			}
		}
	}
}
