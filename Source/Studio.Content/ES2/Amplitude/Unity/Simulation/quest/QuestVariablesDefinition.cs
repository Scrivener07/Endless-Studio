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
	public class QuestVariablesDefinition : INotifyPropertyChanged
	{
		private QuestVariableDefinition[] itemsField;


		/// <remarks/>
		[XmlElement("DroplistVar", typeof(QuestDroplistVariableDefinition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("InterpretedVar", typeof(QuestInterpretedVariableDefinition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("LocalizationVar", typeof(QuestLocalizationVariableDefinition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Var", typeof(QuestVariableDefinition), Form = XmlSchemaForm.Unqualified)]
		public QuestVariableDefinition[] Items
		{
			get { return this.itemsField; }
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
