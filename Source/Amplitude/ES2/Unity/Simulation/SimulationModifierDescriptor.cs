namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SingleSimulationModifierDescriptor))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySimulationModifierDescriptor))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CountSimulationModifierDescriptor))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SimulationModifierDescriptor : object, System.ComponentModel.INotifyPropertyChanged
	{

		private bool searchValueFromPathField;

		private ModifierOperation operationField;

		private float priorityField;

		private string tooltipOverrideField;

		private bool tooltipHiddenField;

		private bool tooltipHiddenIfPathInvalidField;

		private bool valueMustBePositiveField;

		private string pathField;

		private string targetPropertyField;

		public SimulationModifierDescriptor()
		{
			this.searchValueFromPathField = false;
			this.priorityField = ((float)(0F));
			this.tooltipOverrideField = "";
			this.tooltipHiddenField = false;
			this.tooltipHiddenIfPathInvalidField = false;
			this.valueMustBePositiveField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool SearchValueFromPath
		{
			get
			{
				return this.searchValueFromPathField;
			}
			set
			{
				this.searchValueFromPathField = value;
				this.RaisePropertyChanged("SearchValueFromPath");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ModifierOperation Operation
		{
			get
			{
				return this.operationField;
			}
			set
			{
				this.operationField = value;
				this.RaisePropertyChanged("Operation");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float Priority
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string TooltipOverride
		{
			get
			{
				return this.tooltipOverrideField;
			}
			set
			{
				this.tooltipOverrideField = value;
				this.RaisePropertyChanged("TooltipOverride");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool TooltipHidden
		{
			get
			{
				return this.tooltipHiddenField;
			}
			set
			{
				this.tooltipHiddenField = value;
				this.RaisePropertyChanged("TooltipHidden");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool TooltipHiddenIfPathInvalid
		{
			get
			{
				return this.tooltipHiddenIfPathInvalidField;
			}
			set
			{
				this.tooltipHiddenIfPathInvalidField = value;
				this.RaisePropertyChanged("TooltipHiddenIfPathInvalid");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ValueMustBePositive
		{
			get
			{
				return this.valueMustBePositiveField;
			}
			set
			{
				this.valueMustBePositiveField = value;
				this.RaisePropertyChanged("ValueMustBePositive");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
				this.RaisePropertyChanged("Path");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TargetProperty
		{
			get
			{
				return this.targetPropertyField;
			}
			set
			{
				this.targetPropertyField = value;
				this.RaisePropertyChanged("TargetProperty");
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
