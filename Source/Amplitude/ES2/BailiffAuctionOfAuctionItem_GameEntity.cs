namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffSimulationAuctionOfAuctionItem_GameEntity))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Hero))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Improvement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Law))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_Ship))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(BailiffAuction_TimeBubble))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BailiffAuctionOfAuctionItem_GameEntity : object, System.ComponentModel.INotifyPropertyChanged
	{

		private int maximumNumberOfSalesField;

		public BailiffAuctionOfAuctionItem_GameEntity()
		{
			this.maximumNumberOfSalesField = 2147483647;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(2147483647)]
		public int MaximumNumberOfSales
		{
			get
			{
				return this.maximumNumberOfSalesField;
			}
			set
			{
				this.maximumNumberOfSalesField = value;
				this.RaisePropertyChanged("MaximumNumberOfSales");
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
