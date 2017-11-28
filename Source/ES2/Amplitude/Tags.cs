using ES2.EntityFramework;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class Tags : INotifyPropertyChanged, IEntity
	{
		public int ID { get; set; } // EF6


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


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
