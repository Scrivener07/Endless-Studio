using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestTriggeringContextMulti))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestTriggeringContextSolo : INotifyPropertyChanged
	{
		private string participantsVarNameField;

		/// <remarks/>
		[XmlAttribute]
		public string ParticipantsVarName
		{
			get { return this.participantsVarNameField; }
			set
			{
				this.participantsVarNameField = value;
				this.RaisePropertyChanged("ParticipantsVarName");
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
