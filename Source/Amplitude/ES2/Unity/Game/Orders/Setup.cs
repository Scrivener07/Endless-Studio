using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

// OrderPolicySetup
namespace Amplitude.ES2.Unity.Game.Orders
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class Setup : INotifyPropertyChanged
	{
		private OrderPolicyChain[] chainField;
		private string nameField;


		[XmlElement("Chain", Form = XmlSchemaForm.Unqualified)]
		public OrderPolicyChain[] Chain
		{
			get { return this.chainField; }
			set
			{
				this.chainField = value;
				this.RaisePropertyChanged("Chain");
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
