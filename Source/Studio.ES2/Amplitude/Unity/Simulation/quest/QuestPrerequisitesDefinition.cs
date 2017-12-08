using ES2.Editor.Model;
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
	public class QuestPrerequisitesDefinition : INotifyPropertyChanged
	{

		private Prerequisite[] itemsField;

		private string targetField;

		private bool anyTargetField;

		private bool anyPrerequisiteField;

		public QuestPrerequisitesDefinition()
		{
			this.anyTargetField = false;
			this.anyPrerequisiteField = false;
		}

		/// <remarks/>
		[XmlElement("DownloadableContentPrerequisite", typeof(DownloadableContentPrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("GameSettingPrerequisite", typeof(GameSettingPrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("PathPrerequisite", typeof(PathPrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("QuestStatePrerequisite", typeof(QuestStatePrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("TechnologyPrerequisite", typeof(TechnologyPrerequisite), Form = XmlSchemaForm.Unqualified)]
		public Prerequisite[] Items
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
		public string Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				this.RaisePropertyChanged("Target");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool AnyTarget
		{
			get
			{
				return this.anyTargetField;
			}
			set
			{
				this.anyTargetField = value;
				this.RaisePropertyChanged("AnyTarget");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool AnyPrerequisite
		{
			get
			{
				return this.anyPrerequisiteField;
			}
			set
			{
				this.anyPrerequisiteField = value;
				this.RaisePropertyChanged("AnyPrerequisite");
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
