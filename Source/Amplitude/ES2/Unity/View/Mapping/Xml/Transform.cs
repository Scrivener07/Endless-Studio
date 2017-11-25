namespace Amplitude.ES2.Unity.View
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Transform : Node
	{

		private float uniformScaleField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float UniformScale
		{
			get
			{
				return this.uniformScaleField;
			}
			set
			{
				this.uniformScaleField = value;
				this.RaisePropertyChanged("UniformScale");
			}
		}
	}
}
