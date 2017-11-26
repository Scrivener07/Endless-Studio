namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GroundBattleTroopTypeConfig : DatatableElement
	{

		private float spawnXPositionOffsetField;

		private float spawnMinZPositionOffsetField;

		private float spawnMaxZPositionOffsetField;

		private float attackAdditionalDelayField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float SpawnXPositionOffset
		{
			get
			{
				return this.spawnXPositionOffsetField;
			}
			set
			{
				this.spawnXPositionOffsetField = value;
				this.RaisePropertyChanged("SpawnXPositionOffset");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float SpawnMinZPositionOffset
		{
			get
			{
				return this.spawnMinZPositionOffsetField;
			}
			set
			{
				this.spawnMinZPositionOffsetField = value;
				this.RaisePropertyChanged("SpawnMinZPositionOffset");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float SpawnMaxZPositionOffset
		{
			get
			{
				return this.spawnMaxZPositionOffsetField;
			}
			set
			{
				this.spawnMaxZPositionOffsetField = value;
				this.RaisePropertyChanged("SpawnMaxZPositionOffset");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float AttackAdditionalDelay
		{
			get
			{
				return this.attackAdditionalDelayField;
			}
			set
			{
				this.attackAdditionalDelayField = value;
				this.RaisePropertyChanged("AttackAdditionalDelay");
			}
		}
	}
}
