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
	public class RepetitionRules : INotifyPropertyChanged
	{
		private int numberOfOccurrencesPerGameField;

		private int numberOfOccurrencesPerEmpireField;

		private int numberOfConcurrentInstancesField;

		private int numberOfConcurrentInstancesPerEmpireField;

		private int cooldownField;


		public RepetitionRules()
		{
			this.numberOfOccurrencesPerGameField = 0;
			this.numberOfOccurrencesPerEmpireField = 0;
			this.numberOfConcurrentInstancesField = 0;
			this.numberOfConcurrentInstancesPerEmpireField = 0;
			this.cooldownField = 0;
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int NumberOfOccurrencesPerGame
		{
			get
			{
				return this.numberOfOccurrencesPerGameField;
			}
			set
			{
				this.numberOfOccurrencesPerGameField = value;
				this.RaisePropertyChanged("NumberOfOccurrencesPerGame");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int NumberOfOccurrencesPerEmpire
		{
			get
			{
				return this.numberOfOccurrencesPerEmpireField;
			}
			set
			{
				this.numberOfOccurrencesPerEmpireField = value;
				this.RaisePropertyChanged("NumberOfOccurrencesPerEmpire");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int NumberOfConcurrentInstances
		{
			get
			{
				return this.numberOfConcurrentInstancesField;
			}
			set
			{
				this.numberOfConcurrentInstancesField = value;
				this.RaisePropertyChanged("NumberOfConcurrentInstances");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int NumberOfConcurrentInstancesPerEmpire
		{
			get
			{
				return this.numberOfConcurrentInstancesPerEmpireField;
			}
			set
			{
				this.numberOfConcurrentInstancesPerEmpireField = value;
				this.RaisePropertyChanged("NumberOfConcurrentInstancesPerEmpire");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int Cooldown
		{
			get
			{
				return this.cooldownField;
			}
			set
			{
				this.cooldownField = value;
				this.RaisePropertyChanged("Cooldown");
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
