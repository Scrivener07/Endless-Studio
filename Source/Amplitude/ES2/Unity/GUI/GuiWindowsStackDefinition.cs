using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.GUI
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class GuiWindowsStackDefinition : INotifyPropertyChanged
	{
		private Window[] windowField;
		private string nameField;


		[XmlElement("Window", Form = XmlSchemaForm.Unqualified)]
		public Window[] Window
		{
			get { return this.windowField; }
			set
			{
				this.windowField = value;
				this.RaisePropertyChanged("Window");
			}
		}


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
