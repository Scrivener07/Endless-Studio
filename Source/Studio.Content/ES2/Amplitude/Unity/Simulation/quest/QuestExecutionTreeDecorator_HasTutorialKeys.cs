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
	public class QuestExecutionTreeDecorator_HasTutorialKeys : QuestExecutionTreeDecoratorOfEventTutorialKeysChanged
	{

		private TutorialKey[] keyField;

		private TagsComposition compositionField;

		/// <remarks/>
		[XmlElement("Key", Form = XmlSchemaForm.Unqualified)]
		public TutorialKey[] Key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
				this.RaisePropertyChanged("Key");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public TagsComposition Composition
		{
			get
			{
				return this.compositionField;
			}
			set
			{
				this.compositionField = value;
				this.RaisePropertyChanged("Composition");
			}
		}
	}

}