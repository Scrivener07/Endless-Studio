using ES2.Amplitude.Unity.Runtime.Plugins;
using Studio.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Runtime
{
	/// <remarks/>
	[XmlInclude(typeof(AIPlugin))]
	[XmlInclude(typeof(DatabasePlugin))]
	[XmlInclude(typeof(LocalizationPlugin))]
	[XmlInclude(typeof(RegistryPlugin))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public abstract class RuntimePlugin : EntityTypeComplex
	{
		private int priorityField;


		public RuntimePlugin()
		{
			this.priorityField = 0;
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Priority
		{
			get { return this.priorityField; }
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}


	}
}
