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
	public class QuestStepChoiceDefinition : INotifyPropertyChanged
	{

		private QuestStepChoiceItemDefinition[] choiceItemField;

		private int defaultChoiceIndexField;

		private bool isVoteField;

		public QuestStepChoiceDefinition()
		{
			this.defaultChoiceIndexField = 0;
			this.isVoteField = false;
		}

		/// <remarks/>
		[XmlElement("ChoiceItem", Form = XmlSchemaForm.Unqualified)]
		public QuestStepChoiceItemDefinition[] ChoiceItem
		{
			get
			{
				return this.choiceItemField;
			}
			set
			{
				this.choiceItemField = value;
				this.RaisePropertyChanged("ChoiceItem");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int DefaultChoiceIndex
		{
			get
			{
				return this.defaultChoiceIndexField;
			}
			set
			{
				this.defaultChoiceIndexField = value;
				this.RaisePropertyChanged("DefaultChoiceIndex");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsVote
		{
			get
			{
				return this.isVoteField;
			}
			set
			{
				this.isVoteField = value;
				this.RaisePropertyChanged("IsVote");
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