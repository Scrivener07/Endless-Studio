using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class FactionTraitTooltipOverride : INotifyPropertyChanged
	{

		private OverrideType typeField;

		private string overrideNameField;


		[XmlAttribute()]
		public OverrideType Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[XmlAttribute()]
		public string OverrideName
		{
			get { return this.overrideNameField; }
			set
			{
				this.overrideNameField = value;
				this.RaisePropertyChanged("OverrideName");
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
