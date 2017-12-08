using ES2.Editor.Model;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class FactionTraitTooltipOverride : EntityTypeComplex
	{
		private OverrideType typeField;

		private string overrideNameField;


		/// <remarks/>
		[XmlAttribute]
		public OverrideType Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string OverrideName
		{
			get { return this.overrideNameField; }
			set
			{
				this.overrideNameField = value;
				this.RaisePropertyChanged("OverrideName");
			}
		}


	}
}
