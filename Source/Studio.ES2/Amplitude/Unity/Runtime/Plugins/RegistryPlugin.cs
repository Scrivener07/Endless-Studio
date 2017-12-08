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
	public class RegistryPlugin : RuntimePlugin
	{
		private string[] filePathField;


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


	}
}
