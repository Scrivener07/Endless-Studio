using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestAIHintDefinition : INotifyPropertyChanged
	{

		private QuestAIHintResources[] resourceField;

		private QuestInputArgument[] input_VarField;

		private QuestAIHintCategory categoryField;

		private int minAutoResolutionTurnField;

		private int maxAutoResolutionTurnField;

		private float autoResolutionProbabilityField;

		private float motivationField;

		public QuestAIHintDefinition()
		{
			this.categoryField = QuestAIHintCategory.Minimal;
			this.minAutoResolutionTurnField = 0;
			this.maxAutoResolutionTurnField = 0;
			this.autoResolutionProbabilityField = ((float)(0F));
			this.motivationField = ((float)(0F));
		}

		/// <remarks/>
		[XmlElement("Resource", Form = XmlSchemaForm.Unqualified)]
		public QuestAIHintResources[] Resource
		{
			get
			{
				return this.resourceField;
			}
			set
			{
				this.resourceField = value;
				this.RaisePropertyChanged("Resource");
			}
		}

		/// <remarks/>
		[XmlElement("Input_Var", Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument[] Input_Var
		{
			get
			{
				return this.input_VarField;
			}
			set
			{
				this.input_VarField = value;
				this.RaisePropertyChanged("Input_Var");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(QuestAIHintCategory.Minimal)]
		public QuestAIHintCategory Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int MinAutoResolutionTurn
		{
			get
			{
				return this.minAutoResolutionTurnField;
			}
			set
			{
				this.minAutoResolutionTurnField = value;
				this.RaisePropertyChanged("MinAutoResolutionTurn");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int MaxAutoResolutionTurn
		{
			get
			{
				return this.maxAutoResolutionTurnField;
			}
			set
			{
				this.maxAutoResolutionTurnField = value;
				this.RaisePropertyChanged("MaxAutoResolutionTurn");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "0")]
		public float AutoResolutionProbability
		{
			get
			{
				return this.autoResolutionProbabilityField;
			}
			set
			{
				this.autoResolutionProbabilityField = value;
				this.RaisePropertyChanged("AutoResolutionProbability");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "0")]
		public float Motivation
		{
			get
			{
				return this.motivationField;
			}
			set
			{
				this.motivationField = value;
				this.RaisePropertyChanged("Motivation");
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