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
	public partial class DatabasePlugin : RuntimePlugin
	{

		private XmlExtraType[] extraTypesField;

		private string[] filePathField;

		private XmlAttributeOverride[] overridesField;

		private string dataTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("ExtraType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlExtraType[] ExtraTypes
		{
			get
			{
				return this.extraTypesField;
			}
			set
			{
				this.extraTypesField = value;
				this.RaisePropertyChanged("ExtraTypes");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FilePath", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] FilePath
		{
			get
			{
				return this.filePathField;
			}
			set
			{
				this.filePathField = value;
				this.RaisePropertyChanged("FilePath");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Override", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public XmlAttributeOverride[] Overrides
		{
			get
			{
				return this.overridesField;
			}
			set
			{
				this.overridesField = value;
				this.RaisePropertyChanged("Overrides");
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
	}
}
