namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class WeaponSlotDefinition : SlotDefinition
	{

		private WeaponType restrictedWeaponTypeField;

		public WeaponSlotDefinition()
		{
			this.restrictedWeaponTypeField = WeaponType.Undefined;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(WeaponType.Undefined)]
		public WeaponType RestrictedWeaponType
		{
			get
			{
				return this.restrictedWeaponTypeField;
			}
			set
			{
				this.restrictedWeaponTypeField = value;
				this.RaisePropertyChanged("RestrictedWeaponType");
			}
		}
	}
}
