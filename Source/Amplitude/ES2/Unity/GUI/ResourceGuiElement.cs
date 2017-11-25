namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ResourceGuiElement : ExtendedGuiElement
	{

		private string targetEffectField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TargetEffect
		{
			get
			{
				return this.targetEffectField;
			}
			set
			{
				this.targetEffectField = value;
				this.RaisePropertyChanged("TargetEffect");
			}
		}
	}
}
