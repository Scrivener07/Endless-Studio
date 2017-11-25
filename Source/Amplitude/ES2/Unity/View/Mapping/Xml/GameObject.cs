namespace Amplitude.ES2.Unity.View
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GameObject : Node
	{

		private string prefabField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Prefab
		{
			get
			{
				return this.prefabField;
			}
			set
			{
				this.prefabField = value;
				this.RaisePropertyChanged("Prefab");
			}
		}
	}
}
