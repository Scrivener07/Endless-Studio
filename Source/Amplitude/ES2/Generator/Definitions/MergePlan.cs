namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class MergePlan : object, System.ComponentModel.INotifyPropertyChanged
	{

		private SizeDivisionUseCase[] useCaseField;

		private string[][] blockField;

		private string nameField;

		private int majorSpawnBlocksField;


		[System.Xml.Serialization.XmlElementAttribute("UseCase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SizeDivisionUseCase[] UseCase
		{
			get
			{
				return this.useCaseField;
			}
			set
			{
				this.useCaseField = value;
				this.RaisePropertyChanged("UseCase");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("TakenShape", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public string[][] Block
		{
			get
			{
				return this.blockField;
			}
			set
			{
				this.blockField = value;
				this.RaisePropertyChanged("Block");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int MajorSpawnBlocks
		{
			get
			{
				return this.majorSpawnBlocksField;
			}
			set
			{
				this.majorSpawnBlocksField = value;
				this.RaisePropertyChanged("MajorSpawnBlocks");
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
