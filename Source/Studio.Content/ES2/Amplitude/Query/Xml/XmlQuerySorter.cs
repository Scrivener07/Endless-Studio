using ES2.Amplitude.Unity.Simulation;
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
	public class XmlQuerySorter : INotifyPropertyChanged
	{
		private QuestSorterConstellationByDistance sortConstellationByDistanceField;


		/// <summary>
		/// TODO: This property may actually be of type object.
		/// </summary>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestSorterConstellationByDistance SortConstellationByDistance
		{
			get { return this.sortConstellationByDistanceField; }
			set
			{
				this.sortConstellationByDistanceField = value;
				this.RaisePropertyChanged("SortConstellationByDistance");
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
