using System;
using System.Diagnostics;

namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[SerializableAttribute]
	[DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class FactionTraitStartingSenate : FactionTrait
	{

		private XmlNamedReference governmentField;

		private PoliticsWeight[] politicsWeightField;

		private int priorityField;

		public FactionTraitStartingSenate()
		{
			this.priorityField = 0;
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference Government
		{
			get
			{
				return this.governmentField;
			}
			set
			{
				this.governmentField = value;
				this.RaisePropertyChanged("Government");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("PoliticsWeight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PoliticsWeight[] PoliticsWeight
		{
			get
			{
				return this.politicsWeightField;
			}
			set
			{
				this.politicsWeightField = value;
				this.RaisePropertyChanged("PoliticsWeight");
			}
		}


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
	}
}
