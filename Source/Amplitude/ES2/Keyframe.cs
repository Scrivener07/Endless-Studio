namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Keyframe : ValueType
	{

		private float timeField;

		private float valueField;

		private float inTangentField;

		private float outTangentField;

		private int tangentModeField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public float time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
				this.RaisePropertyChanged("time");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public float value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("value");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public float inTangent
		{
			get
			{
				return this.inTangentField;
			}
			set
			{
				this.inTangentField = value;
				this.RaisePropertyChanged("inTangent");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public float outTangent
		{
			get
			{
				return this.outTangentField;
			}
			set
			{
				this.outTangentField = value;
				this.RaisePropertyChanged("outTangent");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int tangentMode
		{
			get
			{
				return this.tangentModeField;
			}
			set
			{
				this.tangentModeField = value;
				this.RaisePropertyChanged("tangentMode");
			}
		}
	}
}
