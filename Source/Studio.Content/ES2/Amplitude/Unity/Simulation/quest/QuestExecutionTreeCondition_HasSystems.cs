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
	public class QuestExecutionTreeCondition_HasSystems : QuestExecutionTreeCondition
	{

		private QuestInputArgument input_EmpiresField;

		private QuestInputArgument input_MinimumAmountField;

		private QuestInputArgument input_MaximumAmountField;

		private QuestInputArgument input_MinimumLevelField;

		private QuestInputArgument input_SystemTypeField;

		private QuestInputArgument input_SystemsField;

		private QuestOutputArgument output_CountField;

		private bool inSameConstellationField;

		private bool ignoreOutpostsField;

		private bool onlyHomeSystemForRootUsersField;

		public QuestExecutionTreeCondition_HasSystems()
		{
			this.inSameConstellationField = false;
			this.ignoreOutpostsField = false;
			this.onlyHomeSystemForRootUsersField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Empires
		{
			get
			{
				return this.input_EmpiresField;
			}
			set
			{
				this.input_EmpiresField = value;
				this.RaisePropertyChanged("Input_Empires");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MinimumAmount
		{
			get
			{
				return this.input_MinimumAmountField;
			}
			set
			{
				this.input_MinimumAmountField = value;
				this.RaisePropertyChanged("Input_MinimumAmount");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_MaximumAmount
		{
			get
			{
				return this.input_MaximumAmountField;
			}
			set
			{
				this.input_MaximumAmountField = value;
				this.RaisePropertyChanged("Input_MaximumAmount");
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
		public QuestInputArgument Input_SystemType
		{
			get
			{
				return this.input_SystemTypeField;
			}
			set
			{
				this.input_SystemTypeField = value;
				this.RaisePropertyChanged("Input_SystemType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Systems
		{
			get
			{
				return this.input_SystemsField;
			}
			set
			{
				this.input_SystemsField = value;
				this.RaisePropertyChanged("Input_Systems");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_Count
		{
			get
			{
				return this.output_CountField;
			}
			set
			{
				this.output_CountField = value;
				this.RaisePropertyChanged("Output_Count");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool InSameConstellation
		{
			get
			{
				return this.inSameConstellationField;
			}
			set
			{
				this.inSameConstellationField = value;
				this.RaisePropertyChanged("InSameConstellation");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IgnoreOutposts
		{
			get
			{
				return this.ignoreOutpostsField;
			}
			set
			{
				this.ignoreOutpostsField = value;
				this.RaisePropertyChanged("IgnoreOutposts");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool OnlyHomeSystemForRootUsers
		{
			get
			{
				return this.onlyHomeSystemForRootUsersField;
			}
			set
			{
				this.onlyHomeSystemForRootUsersField = value;
				this.RaisePropertyChanged("OnlyHomeSystemForRootUsers");
			}
		}
	}

}