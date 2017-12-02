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
	public class QuestExecutionTreeAction_HighlightGui : QuestExecutionTreeAction
	{
		private string keyField;

		private string typeField;

		private bool highlightedField;


		public QuestExecutionTreeAction_HighlightGui()
		{
			this.highlightedField = false;
		}


		/// <remarks/>
		[XmlAttribute]
		public string Key
		{
			get { return this.keyField; }
			set
			{
				this.keyField = value;
				this.RaisePropertyChanged("Key");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public string Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Highlighted
		{
			get { return this.highlightedField; }
			set
			{
				this.highlightedField = value;
				this.RaisePropertyChanged("Highlighted");
			}
		}


	}


	/// <summary>
	/// TODO: Possibly used with QuestExecutionTreeAction_HighlightGui
	/// </summary>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum Type
	{
		FreeForAll,
		Teams
	}
}
