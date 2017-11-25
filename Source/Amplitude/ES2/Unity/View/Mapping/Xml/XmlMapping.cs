using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.View.Mapping.Xml
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class XmlMapping : INotifyPropertyChanged
	{
		private Node[] itemsField;
		private string nameField;


		[XmlElement("Fallback", typeof(Fallback), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("GameObject", typeof(GameObject), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Node", typeof(Node), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Variation", typeof(Variation), Form = XmlSchemaForm.Unqualified)]
		public Node[] Items
		{
			get { return this.itemsField; }
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}


		[XmlAttribute]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
