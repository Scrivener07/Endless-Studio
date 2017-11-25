namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GuiPanelFeatureDescription : object, System.ComponentModel.INotifyPropertyChanged
	{

		private PropertyFilter[] propertyFiltersField;

		private string prefabField;

		private bool hideInCompactModeField;

		private bool doNotHandleCompactModeField;

		private bool showImageField;

		public GuiPanelFeatureDescription()
		{
			this.hideInCompactModeField = false;
			this.doNotHandleCompactModeField = false;
			this.showImageField = true;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public PropertyFilter[] PropertyFilters
		{
			get
			{
				return this.propertyFiltersField;
			}
			set
			{
				this.propertyFiltersField = value;
				this.RaisePropertyChanged("PropertyFilters");
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
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HideInCompactMode
		{
			get
			{
				return this.hideInCompactModeField;
			}
			set
			{
				this.hideInCompactModeField = value;
				this.RaisePropertyChanged("HideInCompactMode");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DoNotHandleCompactMode
		{
			get
			{
				return this.doNotHandleCompactModeField;
			}
			set
			{
				this.doNotHandleCompactModeField = value;
				this.RaisePropertyChanged("DoNotHandleCompactMode");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool ShowImage
		{
			get
			{
				return this.showImageField;
			}
			set
			{
				this.showImageField = value;
				this.RaisePropertyChanged("ShowImage");
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
