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
	public class Command : INotifyPropertyChanged
	{

		private string nameField;

		private string argumentsField;

		private int priorityField;


		public Command()
		{
			this.priorityField = 0;
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

		/// <remarks/>
		[XmlAttribute]
		public string Arguments
		{
			get { return this.argumentsField; }
			set
			{
				this.argumentsField = value;
				this.RaisePropertyChanged("Arguments");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Priority
		{
			get { return this.priorityField; }
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
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
