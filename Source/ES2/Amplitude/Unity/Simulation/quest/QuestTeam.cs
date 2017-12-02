using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestTeam : INotifyPropertyChanged
	{

		private string membersVarNameField;

		private string nameField;

		/// <remarks/>
		[XmlAttribute]
		public string MembersVarName
		{
			get { return this.membersVarNameField; }
			set
			{
				this.membersVarNameField = value;
				this.RaisePropertyChanged("MembersVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
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
