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
	public class QuestExecutionTreeDecorator_HeroAssigned : QuestExecutionTreeDecorator_EmpireEventOfEventHeroAssigned
	{

		private QuestInputArgument input_HeroField;

		private QuestInputArgument input_HeroNameField;

		private QuestInputArgument input_LocationsField;

		private QuestInputArgument input_LocationGUIDsField;

		private QuestInputArgument input_MinimumLevelField;

		private QuestOutputArgument output_HeroField;

		private QuestOutputArgument output_HeroGUIDField;

		private QuestOutputArgument output_FleetField;

		private QuestOutputArgument output_ColonizedStarSystemField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Hero
		{
			get
			{
				return this.input_HeroField;
			}
			set
			{
				this.input_HeroField = value;
				this.RaisePropertyChanged("Input_Hero");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_HeroName
		{
			get
			{
				return this.input_HeroNameField;
			}
			set
			{
				this.input_HeroNameField = value;
				this.RaisePropertyChanged("Input_HeroName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Locations
		{
			get
			{
				return this.input_LocationsField;
			}
			set
			{
				this.input_LocationsField = value;
				this.RaisePropertyChanged("Input_Locations");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_LocationGUIDs
		{
			get
			{
				return this.input_LocationGUIDsField;
			}
			set
			{
				this.input_LocationGUIDsField = value;
				this.RaisePropertyChanged("Input_LocationGUIDs");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumLevel
		{
			get
			{
				return this.input_MinimumLevelField;
			}
			set
			{
				this.input_MinimumLevelField = value;
				this.RaisePropertyChanged("Input_MinimumLevel");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Hero
		{
			get
			{
				return this.output_HeroField;
			}
			set
			{
				this.output_HeroField = value;
				this.RaisePropertyChanged("Output_Hero");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_HeroGUID
		{
			get
			{
				return this.output_HeroGUIDField;
			}
			set
			{
				this.output_HeroGUIDField = value;
				this.RaisePropertyChanged("Output_HeroGUID");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Fleet
		{
			get
			{
				return this.output_FleetField;
			}
			set
			{
				this.output_FleetField = value;
				this.RaisePropertyChanged("Output_Fleet");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_ColonizedStarSystem
		{
			get
			{
				return this.output_ColonizedStarSystemField;
			}
			set
			{
				this.output_ColonizedStarSystemField = value;
				this.RaisePropertyChanged("Output_ColonizedStarSystem");
			}
		}
	}

}