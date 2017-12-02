using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestFilterPlanetByCuriosity : INotifyPropertyChanged
	{

		private string countVarNameField;

		private string empireVarNameField;

		private string displayedTypeVarNameField;

		private PlanetCuriosityFilteringOperation filteringOperationField;

		private PlanetCuriosityCountOperation countOperationField;

		public QuestFilterPlanetByCuriosity()
		{
			this.countOperationField = PlanetCuriosityCountOperation.Min;
		}

		/// <remarks/>
		[XmlAttribute]
		public string CountVarName
		{
			get
			{
				return this.countVarNameField;
			}
			set
			{
				this.countVarNameField = value;
				this.RaisePropertyChanged("CountVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string EmpireVarName
		{
			get
			{
				return this.empireVarNameField;
			}
			set
			{
				this.empireVarNameField = value;
				this.RaisePropertyChanged("EmpireVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string DisplayedTypeVarName
		{
			get
			{
				return this.displayedTypeVarNameField;
			}
			set
			{
				this.displayedTypeVarNameField = value;
				this.RaisePropertyChanged("DisplayedTypeVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public PlanetCuriosityFilteringOperation FilteringOperation
		{
			get
			{
				return this.filteringOperationField;
			}
			set
			{
				this.filteringOperationField = value;
				this.RaisePropertyChanged("FilteringOperation");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(PlanetCuriosityCountOperation.Min)]
		public PlanetCuriosityCountOperation CountOperation
		{
			get
			{
				return this.countOperationField;
			}
			set
			{
				this.countOperationField = value;
				this.RaisePropertyChanged("CountOperation");
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
