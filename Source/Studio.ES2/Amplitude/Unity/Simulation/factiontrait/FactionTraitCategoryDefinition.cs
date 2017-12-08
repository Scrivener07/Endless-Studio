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
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class FactionTraitCategoryDefinition : DatatableElement
	{
		private bool isSubstituteField;


		/// <remarks/>
		[XmlAttribute]
		public bool IsSubstitute
		{
			get { return this.isSubstituteField; }
			set
			{
				this.isSubstituteField = value;
				this.RaisePropertyChanged("IsSubstitute");
			}
		}


	}
}
