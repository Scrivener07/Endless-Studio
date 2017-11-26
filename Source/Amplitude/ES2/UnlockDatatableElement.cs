using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[XmlInclude(typeof(Module))]
	[XmlInclude(typeof(SquadronModule))]
	[XmlInclude(typeof(BridgeModule))]
	[XmlInclude(typeof(SupportModule))]
	[XmlInclude(typeof(MothershipModule))]
	[XmlInclude(typeof(LogisticsModule))]
	[XmlInclude(typeof(DefenseModule))]
	[XmlInclude(typeof(WeaponModule))]
	[XmlInclude(typeof(DestructionModule))]
	[XmlInclude(typeof(HullDefinition))]
	[XmlInclude(typeof(ConstructibleElement))]
	[XmlInclude(typeof(AnomalyReductionDefinition))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class UnlockDatatableElement : DatatableElement
	{
	}
}
