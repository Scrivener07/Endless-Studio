namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class DiplomaticTermGuiElement : ExtendedGuiElement
	{

		private string quoteFormatField;

		private string fallbackQuoteFormatField;

		private int priorityField;

		private string genericFormatNameField;

		private bool concatenateEmpireField;

		public DiplomaticTermGuiElement()
		{
			this.quoteFormatField = "";
			this.fallbackQuoteFormatField = "";
			this.priorityField = 0;
			this.genericFormatNameField = "";
			this.concatenateEmpireField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string QuoteFormat
		{
			get
			{
				return this.quoteFormatField;
			}
			set
			{
				this.quoteFormatField = value;
				this.RaisePropertyChanged("QuoteFormat");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.ComponentModel.DefaultValueAttribute("")]
		public string FallbackQuoteFormat
		{
			get
			{
				return this.fallbackQuoteFormatField;
			}
			set
			{
				this.fallbackQuoteFormatField = value;
				this.RaisePropertyChanged("FallbackQuoteFormat");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Priority
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
		public string GenericFormatName
		{
			get
			{
				return this.genericFormatNameField;
			}
			set
			{
				this.genericFormatNameField = value;
				this.RaisePropertyChanged("GenericFormatName");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ConcatenateEmpire
		{
			get
			{
				return this.concatenateEmpireField;
			}
			set
			{
				this.concatenateEmpireField = value;
				this.RaisePropertyChanged("ConcatenateEmpire");
			}
		}
	}
}
