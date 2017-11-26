using System;
using System.CodeDom.Compiler;

namespace Amplitude.ES2
{
	[Flags]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum EncounterEntityTags
	{
		None = 1,
		Me = 2,
		Other = 4,
		SameShip = 8,
		OtherShip = 16,
		SameFlotilla = 32,
		OtherFlotilla = 64,
		SameGroup = 128,
		OtherGroup = 256,
		EffectInitiator = 512,
		EffectTarget = 1024,
		Alive = 2048,
		Deactivated = 4096,
		Destroyed = 8192,
		SameModule = 16384,
		OtherModule = 32768,
		Arena = 65536,
		Reinforcement = 131072,
		Inactive = 262144,
		MyMainTarget = 524288
	}
}
