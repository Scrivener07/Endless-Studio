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
	public class XmlQuery : INotifyPropertyChanged
	{
		private XmlQueryPrerequisites whereField;

		private XmlQuerySorter orderByField;

		private string sourceField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlQueryPrerequisites Where
		{
			get { return this.whereField; }
			set
			{
				this.whereField = value;
				this.RaisePropertyChanged("Where");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlQuerySorter OrderBy
		{
			get { return this.orderByField; }
			set
			{
				this.orderByField = value;
				this.RaisePropertyChanged("OrderBy");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Source
		{
			get { return this.sourceField; }
			set
			{
				this.sourceField = value;
				this.RaisePropertyChanged("Source");
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
