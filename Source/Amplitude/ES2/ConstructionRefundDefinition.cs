namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ConstructionRefundDefinition : DatatableElement
	{

		private float percentageField;

		private string sourceField;

		private int playerCountField;

		private int unlockCountField;

		public ConstructionRefundDefinition()
		{
			this.playerCountField = -1;
			this.unlockCountField = -1;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float Percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				this.RaisePropertyChanged("Percentage");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
				this.RaisePropertyChanged("Source");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(-1)]
		public int PlayerCount
		{
			get
			{
				return this.playerCountField;
			}
			set
			{
				this.playerCountField = value;
				this.RaisePropertyChanged("PlayerCount");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(-1)]
		public int UnlockCount
		{
			get
			{
				return this.unlockCountField;
			}
			set
			{
				this.unlockCountField = value;
				this.RaisePropertyChanged("UnlockCount");
			}
		}
	}
}
