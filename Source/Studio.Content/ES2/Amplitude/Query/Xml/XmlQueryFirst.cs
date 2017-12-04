using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Query.Xml
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class XmlQueryFirst : INotifyPropertyChanged
	{
		private XmlQuery fromField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlQuery From
		{
			get { return this.fromField; }
			set
			{
				this.fromField = value;
				this.RaisePropertyChanged("From");
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
