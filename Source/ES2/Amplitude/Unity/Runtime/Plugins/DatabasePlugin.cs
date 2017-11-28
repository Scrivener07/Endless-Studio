using ES2.Amplitude.Xml.Serialization;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Runtime.Plugins
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class DatabasePlugin : RuntimePlugin
	{
		private XmlExtraType[] extraTypesField;

		private string[] filePathField;

		private XmlAttributeOverride[] overridesField;

		private string dataTypeField;


		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("ExtraType", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlExtraType[] ExtraTypes
		{
			get { return this.extraTypesField; }
			set
			{
				this.extraTypesField = value;
				this.RaisePropertyChanged("ExtraTypes");
			}
		}

		/// <remarks/>
		[XmlElement("FilePath", Form = XmlSchemaForm.Unqualified)]
		public string[] FilePath
		{
			get { return this.filePathField; }
			set
			{
				this.filePathField = value;
				this.RaisePropertyChanged("FilePath");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem("Override", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlAttributeOverride[] Overrides
		{
			get { return this.overridesField; }
			set
			{
				this.overridesField = value;
				this.RaisePropertyChanged("Overrides");
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


	}
}
