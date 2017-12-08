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
	public class AIPlugin : RuntimePlugin
	{
		private string[] assemblyPathField;

		private Configuration configurationField;


		public AIPlugin()
		{
			this.configurationField = Configuration.Release;
		}


		/// <remarks/>
		[XmlElement("AssemblyPath", Form = XmlSchemaForm.Unqualified)]
		public string[] AssemblyPath
		{
			get { return this.assemblyPathField; }
			set
			{
				this.assemblyPathField = value;
				this.RaisePropertyChanged("AssemblyPath");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(Configuration.Release)]
		public Configuration Configuration
		{
			get { return this.configurationField; }
			set
			{
				this.configurationField = value;
				this.RaisePropertyChanged("Configuration");
			}
		}


	}
}
