using System;
using System.CodeDom.Compiler;

namespace Amplitude.ES2
{
	[Flags]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum CameraShotKeyTransitionLayerTags
	{
		None = 1,
		Position = 2,
		Rotation = 4,
		FieldOfView = 8,
		All = 16
	}
}
