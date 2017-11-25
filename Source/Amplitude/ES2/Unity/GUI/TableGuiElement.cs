namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TableGuiElement : GuiElement
	{

		private ColumnInfo[] columnField;

		private int heightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Column", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ColumnInfo[] Column
		{
			get
			{
				return this.columnField;
			}
			set
			{
				this.columnField = value;
				this.RaisePropertyChanged("Column");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int Height
		{
			get
			{
				return this.heightField;
			}
			set
			{
				this.heightField = value;
				this.RaisePropertyChanged("Height");
			}
		}
	}
}
