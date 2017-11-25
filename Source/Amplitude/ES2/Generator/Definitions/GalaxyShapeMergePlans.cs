namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class GalaxyShapeMergePlans : object, System.ComponentModel.INotifyPropertyChanged
	{

		private MergePlan[] mergePlanField;

		private string shapeNameField;


		[System.Xml.Serialization.XmlElementAttribute("MergePlan", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MergePlan[] MergePlan
		{
			get
			{
				return this.mergePlanField;
			}
			set
			{
				this.mergePlanField = value;
				this.RaisePropertyChanged("MergePlan");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShapeName
		{
			get
			{
				return this.shapeNameField;
			}
			set
			{
				this.shapeNameField = value;
				this.RaisePropertyChanged("ShapeName");
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
