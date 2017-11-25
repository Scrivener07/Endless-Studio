namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraShotKeyLayerTransitionDefinition_Curve : CameraShotKeyLayerTransitionDefinition
	{

		private AnimationCurve curveField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AnimationCurve Curve
		{
			get
			{
				return this.curveField;
			}
			set
			{
				this.curveField = value;
				this.RaisePropertyChanged("Curve");
			}
		}
	}
}
