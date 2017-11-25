using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.Game.Orders
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class OrderPolicyChain : INotifyPropertyChanged
	{
		private OrderPolicyRule[] itemsField;
		private OrderPolicyChainType typeField;


		[XmlElement("PathRule", typeof(OrderPolicyPathRule), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("RegexRule", typeof(OrderPolicyRegexRule), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Rule", typeof(OrderPolicyRule), Form = XmlSchemaForm.Unqualified)]
		public OrderPolicyRule[] Items
		{
			get { return this.itemsField; }
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}


		[XmlAttribute]
		public OrderPolicyChainType Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
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
