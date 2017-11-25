namespace Amplitude.ES2.Unity.View
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Fallback))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(GameObject))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Transform))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(Variation))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Node : object, System.ComponentModel.INotifyPropertyChanged
	{

		private Node[] itemsField;

		private string conditionField;

		private string nameField;

		private string typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Fallback", typeof(Fallback), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("GameObject", typeof(GameObject), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Node", typeof(Node), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Transform", typeof(Transform), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("Variation", typeof(Variation), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Node[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
				this.RaisePropertyChanged("Condition");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
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
