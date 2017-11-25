namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class StarSystemOverviewScanViewGuiElement : ScanViewWindowGuiElement
	{

		private EmpireRankingProperty[] empireRankingPropertiesField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public EmpireRankingProperty[] EmpireRankingProperties
		{
			get
			{
				return this.empireRankingPropertiesField;
			}
			set
			{
				this.empireRankingPropertiesField = value;
				this.RaisePropertyChanged("EmpireRankingProperties");
			}
		}
	}
}
