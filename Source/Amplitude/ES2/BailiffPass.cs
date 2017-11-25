namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BailiffPass : object, System.ComponentModel.INotifyPropertyChanged
	{

		private object[] itemsField;

		private bool loopField;


		[System.Xml.Serialization.XmlElementAttribute("Auction_FactionPact", typeof(BailiffAuction_FactionPact), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_Hero", typeof(BailiffAuction_Hero), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_Improvement", typeof(BailiffAuction_Improvement), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_Law", typeof(BailiffAuction_Law), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_Resource", typeof(BailiffAuction_Resource), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_Ship", typeof(BailiffAuction_Ship), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Auction_TimeBubble", typeof(BailiffAuction_TimeBubble), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object[] Items
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


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool Loop
		{
			get
			{
				return this.loopField;
			}
			set
			{
				this.loopField = value;
				this.RaisePropertyChanged("Loop");
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
