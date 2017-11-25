using System;
using System.CodeDom.Compiler;

namespace Amplitude.ES2.Unity.Game.Orders
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum OrderPolicy
	{
		Unset,
		Accept,
		Reject,
		Drop,
		Queue,
		Log
	}
}
