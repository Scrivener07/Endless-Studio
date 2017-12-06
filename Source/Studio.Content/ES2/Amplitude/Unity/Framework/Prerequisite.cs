using ES2.Amplitude.Unity.Simulation;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Framework
{
	/// <remarks/>
	[XmlInclude(typeof(InterpreterPrerequisite))]
	[XmlInclude(typeof(PathPrerequisite))]
	[XmlInclude(typeof(PathValidityPrerequisite))]
	[XmlInclude(typeof(TechnologyPrerequisite))]
	[XmlInclude(typeof(QuestStatePrerequisite))]
	[XmlInclude(typeof(GameSettingPrerequisite))]
	[XmlInclude(typeof(DownloadableContentPrerequisite))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class Prerequisite : INotifyPropertyChanged
	{

		private bool invertedField;

		private string flagsField;

		private string valueField;

		public Prerequisite()
		{
			this.invertedField = false;
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Inverted
		{
			get { return this.invertedField; }
			set
			{
				this.invertedField = value;
				this.RaisePropertyChanged("Inverted");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Flags
		{
			get { return this.flagsField; }
			set
			{
				this.flagsField = value;
				this.RaisePropertyChanged("Flags");
			}
		}

		/// <remarks/>
		[XmlText]
		public string Value
		{
			get { return this.valueField; }
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
