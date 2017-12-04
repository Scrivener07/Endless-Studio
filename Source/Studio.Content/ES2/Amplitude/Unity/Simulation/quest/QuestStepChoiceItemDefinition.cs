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
	public class QuestStepChoiceItemDefinition : INotifyPropertyChanged
	{
		private QuestPrerequisitesDefinition[] prerequisitesField;

		private int objectiveSetIndexField;


		/// <remarks/>
		[XmlElement("Prerequisites", Form = XmlSchemaForm.Unqualified)]
		public QuestPrerequisitesDefinition[] Prerequisites
		{
			get
			{
				return this.prerequisitesField;
			}
			set
			{
				this.prerequisitesField = value;
				this.RaisePropertyChanged("Prerequisites");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public int ObjectiveSetIndex
		{
			get
			{
				return this.objectiveSetIndexField;
			}
			set
			{
				this.objectiveSetIndexField = value;
				this.RaisePropertyChanged("ObjectiveSetIndex");
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