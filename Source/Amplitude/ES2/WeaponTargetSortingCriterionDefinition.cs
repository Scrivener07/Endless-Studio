namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(WeaponTargetSortingCriterionDefinition_PropertyMultiplier))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class WeaponTargetSortingCriterionDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private WeaponTargetingSortingCriterionScoreModifier[] scoreModifierField;

		private string nameField;

		private float scoreModifiersDefaultValueField;

		private bool ignoredWhenCheckingTargetValidityField;

		public WeaponTargetSortingCriterionDefinition()
		{
			this.scoreModifiersDefaultValueField = ((float)(0F));
			this.ignoredWhenCheckingTargetValidityField = false;
		}


		[System.Xml.Serialization.XmlElementAttribute("ScoreModifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public WeaponTargetingSortingCriterionScoreModifier[] ScoreModifier
		{
			get
			{
				return this.scoreModifierField;
			}
			set
			{
				this.scoreModifierField = value;
				this.RaisePropertyChanged("ScoreModifier");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float ScoreModifiersDefaultValue
		{
			get
			{
				return this.scoreModifiersDefaultValueField;
			}
			set
			{
				this.scoreModifiersDefaultValueField = value;
				this.RaisePropertyChanged("ScoreModifiersDefaultValue");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IgnoredWhenCheckingTargetValidity
		{
			get
			{
				return this.ignoredWhenCheckingTargetValidityField;
			}
			set
			{
				this.ignoredWhenCheckingTargetValidityField = value;
				this.RaisePropertyChanged("IgnoredWhenCheckingTargetValidity");
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
