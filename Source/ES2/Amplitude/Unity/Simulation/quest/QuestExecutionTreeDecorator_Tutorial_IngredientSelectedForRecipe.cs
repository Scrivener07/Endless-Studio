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
	public class QuestExecutionTreeDecorator_Tutorial_IngredientSelectedForRecipe : QuestExecutionTreeDecorator_EmpireEventOfEventTutorial_IngredientSelectedForRecipe
	{

		private QuestInputArgument input_ResourceNameField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_ResourceName
		{
			get
			{
				return this.input_ResourceNameField;
			}
			set
			{
				this.input_ResourceNameField = value;
				this.RaisePropertyChanged("Input_ResourceName");
			}
		}
	}

}