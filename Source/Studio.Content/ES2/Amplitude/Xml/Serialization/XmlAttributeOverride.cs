using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Xml.Serialization
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class XmlAttributeOverride : INotifyPropertyChanged
	{
		private XmlExtraType[] extraTypeField;

		private string nameField;

		private string dataTypeField;


		/// <remarks/>
		[XmlElement("ExtraType", Form = XmlSchemaForm.Unqualified)]
		public XmlExtraType[] ExtraType
		{
			get { return this.extraTypeField; }
			set
			{
				this.extraTypeField = value;
				this.RaisePropertyChanged("ExtraType");
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		[XmlAttribute]
		public string DataType
		{
			get { return this.dataTypeField; }
			set
			{
				this.dataTypeField = value;
				this.RaisePropertyChanged("DataType");
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
