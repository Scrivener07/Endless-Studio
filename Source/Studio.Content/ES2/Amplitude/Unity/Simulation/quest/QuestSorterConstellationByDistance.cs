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
	public class QuestSorterConstellationByDistance : INotifyPropertyChanged
	{
		private string originVarNameField;

		private SortingType sortByField;


		/// <remarks/>
		[XmlAttribute]
		public string OriginVarName
		{
			get { return this.originVarNameField; }
			set
			{
				this.originVarNameField = value;
				this.RaisePropertyChanged("OriginVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public SortingType SortBy
		{
			get { return this.sortByField; }
			set
			{
				this.sortByField = value;
				this.RaisePropertyChanged("SortBy");
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
		public enum SortingType
		{
			Nearest,
			Farthest
		}


	}
}
