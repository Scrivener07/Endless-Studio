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
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class TutorialDefinition : QuestDefinition
	{

		private TutorialKey[] startKeyField;

		private TutorialKey[] visibilityKeyField;

		private TutorialKey[] requiredTutorialKeysField;

		private int priorityField;

		private TutorialPopupLayer layerField;

		private bool isClosableField;

		private TutorialLevel minimumTutorialLevelField;

		public TutorialDefinition()
		{
			this.isClosableField = true;
		}

		/// <remarks/>
		[XmlElement("StartKey", Form = XmlSchemaForm.Unqualified)]
		public TutorialKey[] StartKey
		{
			get
			{
				return this.startKeyField;
			}
			set
			{
				this.startKeyField = value;
				this.RaisePropertyChanged("StartKey");
			}
		}

		/// <remarks/>
		[XmlElement("VisibilityKey", Form = XmlSchemaForm.Unqualified)]
		public TutorialKey[] VisibilityKey
		{
			get
			{
				return this.visibilityKeyField;
			}
			set
			{
				this.visibilityKeyField = value;
				this.RaisePropertyChanged("VisibilityKey");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem(Form = XmlSchemaForm.Unqualified)]
		public TutorialKey[] RequiredTutorialKeys
		{
			get
			{
				return this.requiredTutorialKeysField;
			}
			set
			{
				this.requiredTutorialKeysField = value;
				this.RaisePropertyChanged("RequiredTutorialKeys");
			}
		}

		/// <remarks/>
		[XmlAttribute]
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

		/// <remarks/>
		[XmlAttribute]
		public TutorialPopupLayer Layer
		{
			get
			{
				return this.layerField;
			}
			set
			{
				this.layerField = value;
				this.RaisePropertyChanged("Layer");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(true)]
		public bool IsClosable
		{
			get
			{
				return this.isClosableField;
			}
			set
			{
				this.isClosableField = value;
				this.RaisePropertyChanged("IsClosable");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public TutorialLevel MinimumTutorialLevel
		{
			get
			{
				return this.minimumTutorialLevelField;
			}
			set
			{
				this.minimumTutorialLevelField = value;
				this.RaisePropertyChanged("MinimumTutorialLevel");
			}
		}


	}
}
