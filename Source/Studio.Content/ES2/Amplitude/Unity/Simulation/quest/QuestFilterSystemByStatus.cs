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
	public class QuestFilterSystemByStatus : INotifyPropertyChanged
	{
		private string ownerVarNameField;

		private string nonOwnerVarNameField;

		private ColonizationState colonizationStateField;

		private StarSystemState starSystemStateField;


		public QuestFilterSystemByStatus()
		{
			this.colonizationStateField = ColonizationState.Any;
			this.starSystemStateField = StarSystemState.None;
		}


		/// <remarks/>
		[XmlAttribute]
		public string OwnerVarName
		{
			get
			{
				return this.ownerVarNameField;
			}
			set
			{
				this.ownerVarNameField = value;
				this.RaisePropertyChanged("OwnerVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string NonOwnerVarName
		{
			get
			{
				return this.nonOwnerVarNameField;
			}
			set
			{
				this.nonOwnerVarNameField = value;
				this.RaisePropertyChanged("NonOwnerVarName");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(ColonizationState.Any)]
		public ColonizationState ColonizationState
		{
			get
			{
				return this.colonizationStateField;
			}
			set
			{
				this.colonizationStateField = value;
				this.RaisePropertyChanged("ColonizationState");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(StarSystemState.None)]
		public StarSystemState StarSystemState
		{
			get
			{
				return this.starSystemStateField;
			}
			set
			{
				this.starSystemStateField = value;
				this.RaisePropertyChanged("StarSystemState");
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
