namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableReferenceLaw : DroppableReferenceOfTechnologyDefinition
	{

		private bool constrainedField;

		public DroppableReferenceLaw()
		{
			this.constrainedField = true;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool Constrained
		{
			get
			{
				return this.constrainedField;
			}
			set
			{
				this.constrainedField = value;
				this.RaisePropertyChanged("Constrained");
			}
		}
	}
}
