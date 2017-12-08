using ES2.Amplitude.Unity.Simulation;
using ES2.Editor.Model;
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
	public class XmlQueryPrerequisites : INotifyPropertyChanged
	{
		private object[] itemsField;

		/// <remarks/>
		[XmlElement("FilterByStringValue", typeof(QuestFilterByStringValue), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterConstellationByDistance", typeof(QuestFilterConstellationByDistance), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterPlanetByCuriosity", typeof(QuestFilterPlanetByCuriosity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterShipDesignByModule", typeof(QuestFilterShipDesignByModule), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterSystemByCuriosity", typeof(QuestFilterSystemByCuriosity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterSystemByDistance", typeof(QuestFilterSystemByDistance), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("FilterSystemByStatus", typeof(QuestFilterSystemByStatus), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("InterpreterPrerequisite", typeof(InterpreterPrerequisite), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("IsNot", typeof(QuestFilterDifferentEntity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("PathPrerequisite", typeof(PathPrerequisite), Form = XmlSchemaForm.Unqualified)]
		public object[] Items
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
