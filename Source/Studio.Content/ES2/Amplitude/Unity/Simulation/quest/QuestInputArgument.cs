using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestOutputArgument))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestInputArgument : INotifyPropertyChanged
	{

		private string varNameField;

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