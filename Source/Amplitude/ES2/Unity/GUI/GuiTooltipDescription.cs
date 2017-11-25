namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GuiTooltipDescription : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Offset freeOffsetField;

		private Offset anchorOffsetField;

		private GuiPanelFeatureDescription[] panelFeatureDescriptionField;

		private float priorityField;

		private string tooltipPrefabField;

		private string tooltipWindowField;

		private bool showAnchorsField;

		private string tooltipClassField;

		public GuiTooltipDescription()
		{
			this.priorityField = ((float)(0F));
			this.tooltipWindowField = "";
			this.showAnchorsField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Offset FreeOffset
		{
			get
			{
				return this.freeOffsetField;
			}
			set
			{
				this.freeOffsetField = value;
				this.RaisePropertyChanged("FreeOffset");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Offset AnchorOffset
		{
			get
			{
				return this.anchorOffsetField;
			}
			set
			{
				this.anchorOffsetField = value;
				this.RaisePropertyChanged("AnchorOffset");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PanelFeatureDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GuiPanelFeatureDescription[] PanelFeatureDescription
		{
			get
			{
				return this.panelFeatureDescriptionField;
			}
			set
			{
				this.panelFeatureDescriptionField = value;
				this.RaisePropertyChanged("PanelFeatureDescription");
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
		public string TooltipPrefab
		{
			get
			{
				return this.tooltipPrefabField;
			}
			set
			{
				this.tooltipPrefabField = value;
				this.RaisePropertyChanged("TooltipPrefab");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string TooltipWindow
		{
			get
			{
				return this.tooltipWindowField;
			}
			set
			{
				this.tooltipWindowField = value;
				this.RaisePropertyChanged("TooltipWindow");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ShowAnchors
		{
			get
			{
				return this.showAnchorsField;
			}
			set
			{
				this.showAnchorsField = value;
				this.RaisePropertyChanged("ShowAnchors");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TooltipClass
		{
			get
			{
				return this.tooltipClassField;
			}
			set
			{
				this.tooltipClassField = value;
				this.RaisePropertyChanged("TooltipClass");
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
