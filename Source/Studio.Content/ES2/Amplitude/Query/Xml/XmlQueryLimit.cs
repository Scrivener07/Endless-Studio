using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Query.Xml
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class XmlQueryLimit : INotifyPropertyChanged
	{
		private XmlQuery fromField;

		private Extremities startByField;

		private int limitMinField;

		private int limitMaxField;

		private bool clampField;


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public XmlQuery From
		{
			get { return this.fromField; }
			set
			{
				this.fromField = value;
				this.RaisePropertyChanged("From");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public Extremities StartBy
		{
			get { return this.startByField; }
			set
			{
				this.startByField = value;
				this.RaisePropertyChanged("StartBy");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public int LimitMin
		{
			get { return this.limitMinField; }
			set
			{
				this.limitMinField = value;
				this.RaisePropertyChanged("LimitMin");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public int LimitMax
		{
			get { return this.limitMaxField; }
			set
			{
				this.limitMaxField = value;
				this.RaisePropertyChanged("LimitMax");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public bool Clamp
		{
			get { return this.clampField; }
			set
			{
				this.clampField = value;
				this.RaisePropertyChanged("Clamp");
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


		/// <remarks/>
		[GeneratedCode("xsd", "2.0.50727.3038")]
		[Serializable]
		public enum Extremities
		{
			First,
			Last
		}


	}
}
