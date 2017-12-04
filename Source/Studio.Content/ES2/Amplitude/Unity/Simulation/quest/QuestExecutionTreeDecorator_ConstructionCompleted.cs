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
	public class QuestExecutionTreeDecorator_ConstructionCompleted : QuestExecutionTreeDecorator_EmpireEventOfEventConstructionCompleted
	{

		private QuestInputArgument input_ConstructionNameField;

		private QuestInputArgument input_ConstructionCategoryField;

		private QuestInputArgument input_ConstructionSubCategoryField;

		private QuestInputArgument input_SystemField;

		private ConstructibleType[] input_ValidTypeField;

		private QuestOutputArgument output_SystemField;

		private bool isFailureField;

		public QuestExecutionTreeDecorator_ConstructionCompleted()
		{
			this.isFailureField = false;
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ConstructionName
		{
			get
			{
				return this.input_ConstructionNameField;
			}
			set
			{
				this.input_ConstructionNameField = value;
				this.RaisePropertyChanged("Input_ConstructionName");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ConstructionCategory
		{
			get
			{
				return this.input_ConstructionCategoryField;
			}
			set
			{
				this.input_ConstructionCategoryField = value;
				this.RaisePropertyChanged("Input_ConstructionCategory");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ConstructionSubCategory
		{
			get
			{
				return this.input_ConstructionSubCategoryField;
			}
			set
			{
				this.input_ConstructionSubCategoryField = value;
				this.RaisePropertyChanged("Input_ConstructionSubCategory");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_System
		{
			get
			{
				return this.input_SystemField;
			}
			set
			{
				this.input_SystemField = value;
				this.RaisePropertyChanged("Input_System");
			}
		}

		/// <remarks/>
		[XmlElement("Input_ValidType", Form = XmlSchemaForm.Unqualified)]
		public ConstructibleType[] Input_ValidType
		{
			get
			{
				return this.input_ValidTypeField;
			}
			set
			{
				this.input_ValidTypeField = value;
				this.RaisePropertyChanged("Input_ValidType");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestOutputArgument Output_System
		{
			get
			{
				return this.output_SystemField;
			}
			set
			{
				this.output_SystemField = value;
				this.RaisePropertyChanged("Output_System");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsFailure
		{
			get
			{
				return this.isFailureField;
			}
			set
			{
				this.isFailureField = value;
				this.RaisePropertyChanged("IsFailure");
			}
		}
	}

}