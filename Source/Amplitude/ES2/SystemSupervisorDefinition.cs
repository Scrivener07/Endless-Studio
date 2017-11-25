namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class SystemSupervisorDefinition : DatatableElement
	{

		private SystemAutomatonPolicy policyField;

		private SupervisorGain[] gainsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SystemAutomatonPolicy Policy
		{
			get
			{
				return this.policyField;
			}
			set
			{
				this.policyField = value;
				this.RaisePropertyChanged("Policy");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Gain", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public SupervisorGain[] Gains
		{
			get
			{
				return this.gainsField;
			}
			set
			{
				this.gainsField = value;
				this.RaisePropertyChanged("Gains");
			}
		}
	}
}
