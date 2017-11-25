namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class SquadronModule : Module
	{

		private XmlNamedReference stanceSelectorReferenceField;

		private XmlNamedReference defaultFormationReferenceField;

		private string projectilePrefabPathField;

		private string flakProjectilePrefabPathField;

		private SquadronType typeField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference StanceSelectorReference
		{
			get
			{
				return this.stanceSelectorReferenceField;
			}
			set
			{
				this.stanceSelectorReferenceField = value;
				this.RaisePropertyChanged("StanceSelectorReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlNamedReference DefaultFormationReference
		{
			get
			{
				return this.defaultFormationReferenceField;
			}
			set
			{
				this.defaultFormationReferenceField = value;
				this.RaisePropertyChanged("DefaultFormationReference");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ProjectilePrefabPath
		{
			get
			{
				return this.projectilePrefabPathField;
			}
			set
			{
				this.projectilePrefabPathField = value;
				this.RaisePropertyChanged("ProjectilePrefabPath");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string FlakProjectilePrefabPath
		{
			get
			{
				return this.flakProjectilePrefabPathField;
			}
			set
			{
				this.flakProjectilePrefabPathField = value;
				this.RaisePropertyChanged("FlakProjectilePrefabPath");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public SquadronType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}
	}
}
