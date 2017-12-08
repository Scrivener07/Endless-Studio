using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestQuestTrigger : QuestTrigger
	{
		private Tags tagsField;

		private QuestTriggeringContextSolo[] itemsField;

		private int delayField;


		public QuestQuestTrigger()
		{
			this.delayField = 0;
		}


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get { return this.tagsField; }
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}

		/// <remarks/>
		[XmlElement("QuestContextMulti", typeof(QuestTriggeringContextMulti), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("QuestContextSolo", typeof(QuestTriggeringContextSolo), Form = XmlSchemaForm.Unqualified)]
		public QuestTriggeringContextSolo[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Delay
		{
			get { return this.delayField; }
			set
			{
				this.delayField = value;
				this.RaisePropertyChanged("Delay");
			}
		}


	}
}
