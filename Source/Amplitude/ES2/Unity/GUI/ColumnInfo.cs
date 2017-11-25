namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ColumnInfo : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string[] filterField;

		private string nameField;

		private string descriptionField;

		private int widthField;

		private string prefabField;

		private int digitsNumberField;

		private bool signedField;

		private bool autoResizeHeightField;

		private int filterMenuWidthField;

		private string filterPropertyNameField;

		private bool disableSortingField;

		public ColumnInfo()
		{
			this.digitsNumberField = 0;
			this.signedField = false;
			this.autoResizeHeightField = false;
			this.filterMenuWidthField = 0;
			this.filterPropertyNameField = "";
			this.disableSortingField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Filter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] Filter
		{
			get
			{
				return this.filterField;
			}
			set
			{
				this.filterField = value;
				this.RaisePropertyChanged("Filter");
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
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
				this.RaisePropertyChanged("Width");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Prefab
		{
			get
			{
				return this.prefabField;
			}
			set
			{
				this.prefabField = value;
				this.RaisePropertyChanged("Prefab");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int DigitsNumber
		{
			get
			{
				return this.digitsNumberField;
			}
			set
			{
				this.digitsNumberField = value;
				this.RaisePropertyChanged("DigitsNumber");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Signed
		{
			get
			{
				return this.signedField;
			}
			set
			{
				this.signedField = value;
				this.RaisePropertyChanged("Signed");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool AutoResizeHeight
		{
			get
			{
				return this.autoResizeHeightField;
			}
			set
			{
				this.autoResizeHeightField = value;
				this.RaisePropertyChanged("AutoResizeHeight");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int FilterMenuWidth
		{
			get
			{
				return this.filterMenuWidthField;
			}
			set
			{
				this.filterMenuWidthField = value;
				this.RaisePropertyChanged("FilterMenuWidth");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string FilterPropertyName
		{
			get
			{
				return this.filterPropertyNameField;
			}
			set
			{
				this.filterPropertyNameField = value;
				this.RaisePropertyChanged("FilterPropertyName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DisableSorting
		{
			get
			{
				return this.disableSortingField;
			}
			set
			{
				this.disableSortingField = value;
				this.RaisePropertyChanged("DisableSorting");
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
