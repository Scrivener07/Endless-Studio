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
	public class LocalizationPlugin : RuntimePlugin
	{
		private string[] directoryField;

		private string defaultLanguageField;


		public LocalizationPlugin()
		{
			this.defaultLanguageField = "english";
		}


		/// <remarks/>
		[XmlElement("Directory", Form = XmlSchemaForm.Unqualified)]
		public string[] Directory
		{
			get { return this.directoryField; }
			set
			{
				this.directoryField = value;
				this.RaisePropertyChanged("Directory");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("english")]
		public string DefaultLanguage
		{
			get { return this.defaultLanguageField; }
			set
			{
				this.defaultLanguageField = value;
				this.RaisePropertyChanged("DefaultLanguage");
			}
		}


	}
}
