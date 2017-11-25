namespace Amplitude.ES2
{
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfDroplist))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceList))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableString))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableInteger))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableResource))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableFleet))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfTechnologyDefinition))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceTechnology))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableBlueprint))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableModule))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceLaw))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfHeroDefinition))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceHero))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfUnlockDatatableElement))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceUnlock))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferenceOfEncounterPlayDefinition))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableReferencePlay))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DroppableFaction))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Droppable : object, System.ComponentModel.INotifyPropertyChanged
	{

		private bool canHaveDuplicateField;

		private int weightField;

		private int maxTurnField;

		public Droppable()
		{
			this.canHaveDuplicateField = true;
			this.weightField = 1;
			this.maxTurnField = 0;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool CanHaveDuplicate
		{
			get
			{
				return this.canHaveDuplicateField;
			}
			set
			{
				this.canHaveDuplicateField = value;
				this.RaisePropertyChanged("CanHaveDuplicate");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(1)]
		public int Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int MaxTurn
		{
			get
			{
				return this.maxTurnField;
			}
			set
			{
				this.maxTurnField = value;
				this.RaisePropertyChanged("MaxTurn");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
