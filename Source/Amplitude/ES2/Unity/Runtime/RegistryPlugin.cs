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
	public partial class RegistryPlugin : RuntimePlugin
	{

		private string[] filePathField;

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
	}
}
