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
	public partial class LocalizationPlugin : RuntimePlugin
	{

		private string[] directoryField;

		private string defaultLanguageField;

		public LocalizationPlugin()
		{
			this.defaultLanguageField = "english";
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Directory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] Directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
				this.RaisePropertyChanged("Directory");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("english")]
		public string DefaultLanguage
		{
			get
			{
				return this.defaultLanguageField;
			}
			set
			{
				this.defaultLanguageField = value;
				this.RaisePropertyChanged("DefaultLanguage");
			}
		}
	}
}
