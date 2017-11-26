namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GameSettingRestrictionDefinition : DatatableElement
	{

		private GameSettingDefinition restrictingSettingField;

		private GameSettingDefinition restrictedSettingField;

		private RestrictionSet[] restrictionSetField;

		private string restrictingSetting1Field;

		private string restrictedSetting1Field;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GameSettingDefinition RestrictingSetting
		{
			get
			{
				return this.restrictingSettingField;
			}
			set
			{
				this.restrictingSettingField = value;
				this.RaisePropertyChanged("RestrictingSetting");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GameSettingDefinition RestrictedSetting
		{
			get
			{
				return this.restrictedSettingField;
			}
			set
			{
				this.restrictedSettingField = value;
				this.RaisePropertyChanged("RestrictedSetting");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("RestrictionSet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RestrictionSet[] RestrictionSet
		{
			get
			{
				return this.restrictionSetField;
			}
			set
			{
				this.restrictionSetField = value;
				this.RaisePropertyChanged("RestrictionSet");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute("RestrictingSetting")]
		public string RestrictingSetting1
		{
			get
			{
				return this.restrictingSetting1Field;
			}
			set
			{
				this.restrictingSetting1Field = value;
				this.RaisePropertyChanged("RestrictingSetting1");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute("RestrictedSetting")]
		public string RestrictedSetting1
		{
			get
			{
				return this.restrictedSetting1Field;
			}
			set
			{
				this.restrictedSetting1Field = value;
				this.RaisePropertyChanged("RestrictedSetting1");
			}
		}
	}
}
