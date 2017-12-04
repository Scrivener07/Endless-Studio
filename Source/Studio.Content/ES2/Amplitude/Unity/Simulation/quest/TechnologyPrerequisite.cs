using ES2.Amplitude.Unity.Framework;
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
	public class TechnologyPrerequisite : PathValidityPrerequisite
	{
		private bool unlockHiddenField;


		public TechnologyPrerequisite()
		{
			this.unlockHiddenField = false;
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool UnlockHidden
		{
			get { return this.unlockHiddenField; }
			set
			{
				this.unlockHiddenField = value;
				this.RaisePropertyChanged("UnlockHidden");
			}
		}


	}
}
