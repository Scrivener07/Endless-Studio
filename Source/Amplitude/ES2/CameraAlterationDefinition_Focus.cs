namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraAlterationDefinition_Focus : CameraAlterationDefinition
	{

		private int indexField;

		public CameraAlterationDefinition_Focus()
		{
			this.indexField = 0;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
				this.RaisePropertyChanged("Index");
			}
		}
	}
}
