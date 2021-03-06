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
	public class QuestExecutionTreeDecorator_NameChanged : QuestExecutionTreeDecoratorOfEventLocalizedNameChanged
	{

		private QuestInputArgument input_EntitiesField;

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public QuestInputArgument Input_Entities
		{
			get
			{
				return this.input_EntitiesField;
			}
			set
			{
				this.input_EntitiesField = value;
				this.RaisePropertyChanged("Input_Entities");
			}
		}
	}

}