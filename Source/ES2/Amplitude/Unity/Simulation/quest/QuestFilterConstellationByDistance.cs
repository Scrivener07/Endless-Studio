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
	public class QuestFilterConstellationByDistance : INotifyPropertyChanged
	{
		private string originVarNameField;

		private float minDistanceField;

		private float maxDistanceField;


		public QuestFilterConstellationByDistance()
		{
			this.minDistanceField = ((float)(-1F));
			this.maxDistanceField = ((float)(-1F));
		}


		/// <remarks/>
		[XmlAttribute]
		public string OriginVarName
		{
			get
			{
				return this.originVarNameField;
			}
			set
			{
				this.originVarNameField = value;
				this.RaisePropertyChanged("OriginVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "-1")]
		public float MinDistance
		{
			get
			{
				return this.minDistanceField;
			}
			set
			{
				this.minDistanceField = value;
				this.RaisePropertyChanged("MinDistance");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "-1")]
		public float MaxDistance
		{
			get
			{
				return this.maxDistanceField;
			}
			set
			{
				this.maxDistanceField = value;
				this.RaisePropertyChanged("MaxDistance");
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
