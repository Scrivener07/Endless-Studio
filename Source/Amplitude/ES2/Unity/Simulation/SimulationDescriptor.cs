namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class SimulationDescriptor : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SimulationPropertyDescriptor[] itemsField;

		private SimulationModifierDescriptor[] items1Field;

		private bool isSerializableField;

		private string nameField;

		private string typeField;

		public SimulationDescriptor()
		{
			this.isSerializableField = true;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Property", typeof(SimulationPropertyDescriptor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ProportionalProperty", typeof(SimulationPropertyDescriptor_Proportional), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationPropertyDescriptor[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BinaryModifier", typeof(BinarySimulationModifierDescriptor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CountModifier", typeof(CountSimulationModifierDescriptor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Modifier", typeof(SingleSimulationModifierDescriptor), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SimulationModifierDescriptor[] Items1
		{
			get
			{
				return this.items1Field;
			}
			set
			{
				this.items1Field = value;
				this.RaisePropertyChanged("Items1");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
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
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
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
