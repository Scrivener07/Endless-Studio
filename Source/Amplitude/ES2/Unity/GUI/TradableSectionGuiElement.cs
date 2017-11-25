namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TradableSectionGuiElement : ExtendedGuiElement
	{

		private TableGuiElement tableGuiElementField;

		private int orderField;

		private string resourceTypeField;

		private bool canSellInMarketplaceScreenField;

		private bool canBuyInMarketplaceScreenField;

		public TradableSectionGuiElement()
		{
			this.resourceTypeField = "";
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TableGuiElement TableGuiElement
		{
			get
			{
				return this.tableGuiElementField;
			}
			set
			{
				this.tableGuiElementField = value;
				this.RaisePropertyChanged("TableGuiElement");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string ResourceType
		{
			get
			{
				return this.resourceTypeField;
			}
			set
			{
				this.resourceTypeField = value;
				this.RaisePropertyChanged("ResourceType");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CanSellInMarketplaceScreen
		{
			get
			{
				return this.canSellInMarketplaceScreenField;
			}
			set
			{
				this.canSellInMarketplaceScreenField = value;
				this.RaisePropertyChanged("CanSellInMarketplaceScreen");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CanBuyInMarketplaceScreen
		{
			get
			{
				return this.canBuyInMarketplaceScreenField;
			}
			set
			{
				this.canBuyInMarketplaceScreenField = value;
				this.RaisePropertyChanged("CanBuyInMarketplaceScreen");
			}
		}
	}
}
