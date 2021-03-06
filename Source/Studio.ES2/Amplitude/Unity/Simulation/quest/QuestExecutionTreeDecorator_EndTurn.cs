using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeDecorator_Wait))]
	[XmlInclude(typeof(QuestExecutionTreeDecorator_GuardNode))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeDecorator_EndTurn : QuestExecutionTreeDecoratorOfEventEndTurn
	{
	}

}