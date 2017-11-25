using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplitude.ES2.Unity.Runtime
{
	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(AIPlugin))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DatabasePlugin))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalizationPlugin))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistryPlugin))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class RuntimePlugin : object, System.ComponentModel.INotifyPropertyChanged
	{

		private int priorityField;

		public RuntimePlugin()
		{
			this.priorityField = 0;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(0)]
		public int Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
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
