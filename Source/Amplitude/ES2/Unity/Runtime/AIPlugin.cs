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
	public partial class AIPlugin : RuntimePlugin
	{

		private string[] assemblyPathField;

		private Configuration configurationField;

		public AIPlugin()
		{
			this.configurationField = Configuration.Release;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AssemblyPath", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AssemblyPath
		{
			get
			{
				return this.assemblyPathField;
			}
			set
			{
				this.assemblyPathField = value;
				this.RaisePropertyChanged("AssemblyPath");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(Configuration.Release)]
		public Configuration Configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
				this.RaisePropertyChanged("Configuration");
			}
		}
	}
}
