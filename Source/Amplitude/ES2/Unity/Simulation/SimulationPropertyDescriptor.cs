namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(SimulationPropertyDescriptor_Proportional))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class SimulationPropertyDescriptor : object, System.ComponentModel.INotifyPropertyChanged
	{

		private float baseValueField;

		private SimulationPropertyComposition compositionField;

		private SimulationPropertyRoundingFunction roundingFunctionField;

		private bool isSealedField;

		private bool isSerializableField;

		private string nameField;

		private string maxValueField;

		private string minValueField;

		public SimulationPropertyDescriptor()
		{
			this.baseValueField = ((float)(0F));
			this.compositionField = SimulationPropertyComposition.None;
			this.roundingFunctionField = SimulationPropertyRoundingFunction.None;
			this.isSealedField = false;
			this.isSerializableField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
		public float BaseValue
		{
			get
			{
				return this.baseValueField;
			}
			set
			{
				this.baseValueField = value;
				this.RaisePropertyChanged("BaseValue");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(SimulationPropertyComposition.None)]
		public SimulationPropertyComposition Composition
		{
			get
			{
				return this.compositionField;
			}
			set
			{
				this.compositionField = value;
				this.RaisePropertyChanged("Composition");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(SimulationPropertyRoundingFunction.None)]
		public SimulationPropertyRoundingFunction RoundingFunction
		{
			get
			{
				return this.roundingFunctionField;
			}
			set
			{
				this.roundingFunctionField = value;
				this.RaisePropertyChanged("RoundingFunction");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsSealed
		{
			get
			{
				return this.isSealedField;
			}
			set
			{
				this.isSealedField = value;
				this.RaisePropertyChanged("IsSealed");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IsSerializable
		{
			get
			{
				return this.isSerializableField;
			}
			set
			{
				this.isSerializableField = value;
				this.RaisePropertyChanged("IsSerializable");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MaxValue
		{
			get
			{
				return this.maxValueField;
			}
			set
			{
				this.maxValueField = value;
				this.RaisePropertyChanged("MaxValue");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MinValue
		{
			get
			{
				return this.minValueField;
			}
			set
			{
				this.minValueField = value;
				this.RaisePropertyChanged("MinValue");
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
