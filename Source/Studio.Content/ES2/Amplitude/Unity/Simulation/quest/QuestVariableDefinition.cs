using ES2.Amplitude.Query.Xml;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestDroplistVariableDefinition))]
	[XmlInclude(typeof(QuestLocalizationVariableDefinition))]
	[XmlInclude(typeof(QuestInterpretedVariableDefinition))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestVariableDefinition : INotifyPropertyChanged
	{
		private object[] itemsField;

		private string varNameField;

		private int intValueField;

		private string stringValueField;

		private bool sendToClientField;

		private bool isGlobalField;

		private bool overWriteGlobalField;

		private bool autoLockTargetsField;

		private bool ignoreLockedTargetsField;


		public QuestVariableDefinition()
		{
			this.intValueField = 0;
			this.sendToClientField = false;
			this.isGlobalField = false;
			this.overWriteGlobalField = false;
			this.autoLockTargetsField = false;
			this.ignoreLockedTargetsField = false;
		}



		/// <remarks/>
		[XmlElement("Any", typeof(XmlQueryAny), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Count", typeof(XmlQueryCount), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("First", typeof(XmlQueryFirst), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("From", typeof(XmlQuery), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Last", typeof(XmlQueryLast), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Limit", typeof(XmlQueryLimit), Form = XmlSchemaForm.Unqualified)]
		public object[] Items
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
		public string VarName
		{
			get
			{
				return this.varNameField;
			}
			set
			{
				this.varNameField = value;
				this.RaisePropertyChanged("VarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int IntValue
		{
			get
			{
				return this.intValueField;
			}
			set
			{
				this.intValueField = value;
				this.RaisePropertyChanged("IntValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string StringValue
		{
			get
			{
				return this.stringValueField;
			}
			set
			{
				this.stringValueField = value;
				this.RaisePropertyChanged("StringValue");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool SendToClient
		{
			get
			{
				return this.sendToClientField;
			}
			set
			{
				this.sendToClientField = value;
				this.RaisePropertyChanged("SendToClient");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsGlobal
		{
			get
			{
				return this.isGlobalField;
			}
			set
			{
				this.isGlobalField = value;
				this.RaisePropertyChanged("IsGlobal");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool OverWriteGlobal
		{
			get
			{
				return this.overWriteGlobalField;
			}
			set
			{
				this.overWriteGlobalField = value;
				this.RaisePropertyChanged("OverWriteGlobal");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool AutoLockTargets
		{
			get
			{
				return this.autoLockTargetsField;
			}
			set
			{
				this.autoLockTargetsField = value;
				this.RaisePropertyChanged("AutoLockTargets");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IgnoreLockedTargets
		{
			get
			{
				return this.ignoreLockedTargetsField;
			}
			set
			{
				this.ignoreLockedTargetsField = value;
				this.RaisePropertyChanged("IgnoreLockedTargets");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
