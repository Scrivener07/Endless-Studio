using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2.Simulation
{
	[GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[SerializableAttribute]
	[DebuggerStepThroughAttribute]
	[DesignerCategoryAttribute("code")]
	[XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class FactionTraitCategoryDefinition : DatatableElement
	{

		private bool isSubstituteField;


		[XmlAttributeAttribute]
		public bool IsSubstitute
		{
			get
			{
				return this.isSubstituteField;
			}
			set
			{
				this.isSubstituteField = value;
				this.RaisePropertyChanged("IsSubstitute");
			}
		}


	}
}