namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PopulationModifiersTrait : PopulationTrait
	{

		private PopulationModifierDefinition[] modifiersField;

		private PopulationModifierDefinition[] assimilatedModifiersField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Modifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public PopulationModifierDefinition[] Modifiers
		{
			get
			{
				return this.modifiersField;
			}
			set
			{
				this.modifiersField = value;
				this.RaisePropertyChanged("Modifiers");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Modifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public PopulationModifierDefinition[] AssimilatedModifiers
		{
			get
			{
				return this.assimilatedModifiersField;
			}
			set
			{
				this.assimilatedModifiersField = value;
				this.RaisePropertyChanged("AssimilatedModifiers");
			}
		}
	}
}
