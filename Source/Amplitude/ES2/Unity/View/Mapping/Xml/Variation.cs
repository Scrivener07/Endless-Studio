namespace Amplitude.ES2.Unity.View
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Variation : Node
	{

		private string valuesField;

		private string weightsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
				this.RaisePropertyChanged("Values");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Weights
		{
			get
			{
				return this.weightsField;
			}
			set
			{
				this.weightsField = value;
				this.RaisePropertyChanged("Weights");
			}
		}
	}
}
