namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class TechnologyStageDefinition : ScienceConstructibleElement
	{

		private string countPropertyNameField;

		private int unlockCountField;

		private int stageNumberField;

		private string technologyQuadrantField;

		public TechnologyStageDefinition()
		{
			this.unlockCountField = 0;
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CountPropertyName
		{
			get
			{
				return this.countPropertyNameField;
			}
			set
			{
				this.countPropertyNameField = value;
				this.RaisePropertyChanged("CountPropertyName");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int UnlockCount
		{
			get
			{
				return this.unlockCountField;
			}
			set
			{
				this.unlockCountField = value;
				this.RaisePropertyChanged("UnlockCount");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int StageNumber
		{
			get
			{
				return this.stageNumberField;
			}
			set
			{
				this.stageNumberField = value;
				this.RaisePropertyChanged("StageNumber");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TechnologyQuadrant
		{
			get
			{
				return this.technologyQuadrantField;
			}
			set
			{
				this.technologyQuadrantField = value;
				this.RaisePropertyChanged("TechnologyQuadrant");
			}
		}
	}
}
