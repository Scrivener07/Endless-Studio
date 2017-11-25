namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class FidsiParametersGuiElement : WindowGuiElement
	{

		private FidsThreshold[] fidsThresholdsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public FidsThreshold[] FidsThresholds
		{
			get
			{
				return this.fidsThresholdsField;
			}
			set
			{
				this.fidsThresholdsField = value;
				this.RaisePropertyChanged("FidsThresholds");
			}
		}
	}
}
