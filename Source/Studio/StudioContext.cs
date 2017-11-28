using Amplitude.Unity.Runtime;
using System;

namespace Studio
{
	public class StudioContext
	{
		public FactionAffinity DataSource { get { return current; } }
		FactionAffinity current;


		public StudioContext()
		{
			current = new FactionAffinity();
		}


		private void Save(RuntimeModule runtimeModule)
		{
			runtimeModule.Serialize(Environment.CurrentDirectory);
		}


	}
}
