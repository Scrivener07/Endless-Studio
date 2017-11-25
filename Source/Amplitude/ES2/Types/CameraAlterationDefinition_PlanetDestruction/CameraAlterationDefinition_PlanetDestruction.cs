using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using AmbiguousType = Amplitude.ES2.Types.CameraAlterationDefinition_PlanetDestruction.Type;

namespace Amplitude.ES2
{
	[GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class CameraAlterationDefinition_PlanetDestruction : CameraAlterationDefinition
	{
		private AmbiguousType eventTypeField;


		[XmlAttribute]
		public AmbiguousType EventType
		{
			get
			{
				return this.eventTypeField;
			}
			set
			{
				this.eventTypeField = value;
				this.RaisePropertyChanged("EventType");
			}
		}


	}
}
