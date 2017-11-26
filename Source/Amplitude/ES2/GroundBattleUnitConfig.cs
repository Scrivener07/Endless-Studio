namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GroundBattleUnitConfig : DatatableElement
	{

		private string affinityField;

		private GroundBattleTroopType troopTypeField;

		private string animatorOverrideControllerPathField;

		private bool hasAttackRecoveryAnimField;

		private float socleSizeField;

		private float visualYPositionOffsetField;

		private float collisionXRadiusField;

		private float collisionZRadiusField;

		private bool onlyAvoidSameTypeCollisionField;

		private string impactPrefabPathField;


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Affinity
		{
			get
			{
				return this.affinityField;
			}
			set
			{
				this.affinityField = value;
				this.RaisePropertyChanged("Affinity");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public GroundBattleTroopType TroopType
		{
			get
			{
				return this.troopTypeField;
			}
			set
			{
				this.troopTypeField = value;
				this.RaisePropertyChanged("TroopType");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AnimatorOverrideControllerPath
		{
			get
			{
				return this.animatorOverrideControllerPathField;
			}
			set
			{
				this.animatorOverrideControllerPathField = value;
				this.RaisePropertyChanged("AnimatorOverrideControllerPath");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool HasAttackRecoveryAnim
		{
			get
			{
				return this.hasAttackRecoveryAnimField;
			}
			set
			{
				this.hasAttackRecoveryAnimField = value;
				this.RaisePropertyChanged("HasAttackRecoveryAnim");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float SocleSize
		{
			get
			{
				return this.socleSizeField;
			}
			set
			{
				this.socleSizeField = value;
				this.RaisePropertyChanged("SocleSize");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float VisualYPositionOffset
		{
			get
			{
				return this.visualYPositionOffsetField;
			}
			set
			{
				this.visualYPositionOffsetField = value;
				this.RaisePropertyChanged("VisualYPositionOffset");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float CollisionXRadius
		{
			get
			{
				return this.collisionXRadiusField;
			}
			set
			{
				this.collisionXRadiusField = value;
				this.RaisePropertyChanged("CollisionXRadius");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float CollisionZRadius
		{
			get
			{
				return this.collisionZRadiusField;
			}
			set
			{
				this.collisionZRadiusField = value;
				this.RaisePropertyChanged("CollisionZRadius");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool OnlyAvoidSameTypeCollision
		{
			get
			{
				return this.onlyAvoidSameTypeCollisionField;
			}
			set
			{
				this.onlyAvoidSameTypeCollisionField = value;
				this.RaisePropertyChanged("OnlyAvoidSameTypeCollision");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ImpactPrefabPath
		{
			get
			{
				return this.impactPrefabPathField;
			}
			set
			{
				this.impactPrefabPathField = value;
				this.RaisePropertyChanged("ImpactPrefabPath");
			}
		}
	}
}
