using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.Game.Orders
{
	[XmlInclude(typeof(OrderPolicyPathRule))]
	[XmlInclude(typeof(OrderPolicyRegexRule))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class OrderPolicyRule : INotifyPropertyChanged
	{
		private OrderPolicy policyField;
		private string valueField;


		[XmlAttribute]
		public OrderPolicy Policy
		{
			get { return this.policyField; }
			set
			{
				this.policyField = value;
				this.RaisePropertyChanged("Policy");
			}
		}


		[XmlText]
		public string Value
		{
			get { return this.valueField; }
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
