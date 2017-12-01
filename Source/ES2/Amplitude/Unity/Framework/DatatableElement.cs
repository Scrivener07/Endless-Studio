using ES2.Amplitude.Unity.Simulation;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Framework
{
	[XmlInclude(typeof(FactionTrait))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionAffinity))]
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlInclude(typeof(Faction))]
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(MajorFaction))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class DatatableElement : INotifyPropertyChanged
	{

		private string nameField;


		/// <remarks/>
		[XmlAttribute]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
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

	public interface IDatatableElement
	{
		string Name { get; }
		void PostDeserialization();
	}
}
