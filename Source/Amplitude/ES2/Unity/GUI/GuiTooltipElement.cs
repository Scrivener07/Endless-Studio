namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GuiTooltipElement : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string effectOverrideField;

		private bool percentField;

		private string percentFormatField;

		private bool ignoreField;

		private string temporaryEffectNameField;

		private int customTurnDurationField;

		public GuiTooltipElement()
		{
			this.percentField = false;
			this.percentFormatField = "";
			this.ignoreField = false;
			this.temporaryEffectNameField = "";
			this.customTurnDurationField = -1;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string EffectOverride
		{
			get
			{
				return this.effectOverrideField;
			}
			set
			{
				this.effectOverrideField = value;
				this.RaisePropertyChanged("EffectOverride");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string PercentFormat
		{
			get
			{
				return this.percentFormatField;
			}
			set
			{
				this.percentFormatField = value;
				this.RaisePropertyChanged("PercentFormat");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Ignore
		{
			get
			{
				return this.ignoreField;
			}
			set
			{
				this.ignoreField = value;
				this.RaisePropertyChanged("Ignore");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string TemporaryEffectName
		{
			get
			{
				return this.temporaryEffectNameField;
			}
			set
			{
				this.temporaryEffectNameField = value;
				this.RaisePropertyChanged("TemporaryEffectName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(-1)]
		public int CustomTurnDuration
		{
			get
			{
				return this.customTurnDurationField;
			}
			set
			{
				this.customTurnDurationField = value;
				this.RaisePropertyChanged("CustomTurnDuration");
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
