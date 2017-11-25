namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class DroppableReferenceHero : DroppableReferenceOfHeroDefinition
	{

		private bool spawnField;

		private int levelField;

		public DroppableReferenceHero()
		{
			this.spawnField = false;
			this.levelField = 1;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool Spawn
		{
			get
			{
				return this.spawnField;
			}
			set
			{
				this.spawnField = value;
				this.RaisePropertyChanged("Spawn");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int Level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
				this.RaisePropertyChanged("Level");
			}
		}
	}
}
