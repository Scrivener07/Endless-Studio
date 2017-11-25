namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class DamageDataGuiElement : ExtendedGuiElement
	{

		private DamageModifier[] damageModifiersField;

		private bool inverseApplicationScopeField;

		public DamageDataGuiElement()
		{
			this.inverseApplicationScopeField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public DamageModifier[] DamageModifiers
		{
			get
			{
				return this.damageModifiersField;
			}
			set
			{
				this.damageModifiersField = value;
				this.RaisePropertyChanged("DamageModifiers");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool InverseApplicationScope
		{
			get
			{
				return this.inverseApplicationScopeField;
			}
			set
			{
				this.inverseApplicationScopeField = value;
				this.RaisePropertyChanged("InverseApplicationScope");
			}
		}
	}
}
