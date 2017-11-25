using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.GUI
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class Window : INotifyPropertyChanged
	{
		private string prefabPathField;
		private bool outGameField;
		private bool debugWindowField;


		public Window()
		{
			this.outGameField = false;
			this.debugWindowField = false;
		}


		[XmlAttribute]
		public string PrefabPath
		{
			get { return this.prefabPathField; }
			set
			{
				this.prefabPathField = value;
				this.RaisePropertyChanged("PrefabPath");
			}
		}


		[XmlAttribute]
		[DefaultValue(false)]
		public bool OutGame
		{
			get { return this.outGameField; }
			set
			{
				this.outGameField = value;
				this.RaisePropertyChanged("OutGame");
			}
		}


		[XmlAttribute]
		[DefaultValue(false)]
		public bool DebugWindow
		{
			get { return this.debugWindowField; }
			set
			{
				this.debugWindowField = value;
				this.RaisePropertyChanged("DebugWindow");
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
