using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplitude.ES2.Unity.Runtime
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class XmlAttributeOverride : object, System.ComponentModel.INotifyPropertyChanged
	{

		private XmlExtraType[] extraTypeField;

		private string nameField;

		private string dataTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ExtraType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlExtraType[] ExtraType
		{
			get
			{
				return this.extraTypeField;
			}
			set
			{
				this.extraTypeField = value;
				this.RaisePropertyChanged("ExtraType");
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
		public string DataType
		{
			get
			{
				return this.dataTypeField;
			}
			set
			{
				this.dataTypeField = value;
				this.RaisePropertyChanged("DataType");
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
