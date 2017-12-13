using ES2.Editor.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Localization
{
	/// <remarks/>
	[XmlRoot("LocalizationPair")]
	[XmlType("LocalizationPair")]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class LocalizationDatatableElement : DatatableElement
	{
		private string valueField;

		/// <remarks/>
		[XmlText]
		public string Value
		{
			get { return this.valueField; }
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}


	}
}
