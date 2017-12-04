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
	public class EmpireDistribution : INotifyPropertyChanged
	{

		private QuestTeam[] teamField;

		private Type typeField;

		/// <remarks/>
		[XmlElement("Team", Form = XmlSchemaForm.Unqualified)]
		public QuestTeam[] Team
		{
			get { return this.teamField; }
			set
			{
				this.teamField = value;
				this.RaisePropertyChanged("Team");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public Type Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
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
