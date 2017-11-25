namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class VictoryScreenGuiElement : WindowGuiElement
	{

		private string[] gameStatisticsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("GameStatisticReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public string[] GameStatistics
		{
			get
			{
				return this.gameStatisticsField;
			}
			set
			{
				this.gameStatisticsField = value;
				this.RaisePropertyChanged("GameStatistics");
			}
		}
	}
}
