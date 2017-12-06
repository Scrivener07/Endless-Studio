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
	public class GlobalRepetitionRules : INotifyPropertyChanged
	{
		private int globalCooldownField;

		private GlobalCooldownLiability globalCooldownLiabilityField;

		private int numberOfGlobalQuestConcurrentInstancesField;


		public GlobalRepetitionRules()
		{
			this.globalCooldownField = 0;
			this.globalCooldownLiabilityField = GlobalCooldownLiability.Default;
			this.numberOfGlobalQuestConcurrentInstancesField = 0;
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int GlobalCooldown
		{
			get
			{
				return this.globalCooldownField;
			}
			set
			{
				this.globalCooldownField = value;
				this.RaisePropertyChanged("GlobalCooldown");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(GlobalCooldownLiability.Default)]
		public GlobalCooldownLiability GlobalCooldownLiability
		{
			get
			{
				return this.globalCooldownLiabilityField;
			}
			set
			{
				this.globalCooldownLiabilityField = value;
				this.RaisePropertyChanged("GlobalCooldownLiability");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int NumberOfGlobalQuestConcurrentInstances
		{
			get
			{
				return this.numberOfGlobalQuestConcurrentInstancesField;
			}
			set
			{
				this.numberOfGlobalQuestConcurrentInstancesField = value;
				this.RaisePropertyChanged("NumberOfGlobalQuestConcurrentInstances");
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
