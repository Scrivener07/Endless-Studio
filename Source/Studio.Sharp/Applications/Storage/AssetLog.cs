using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Sharp.Applications.Storage
{
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class AssetLog : ObjectComponent<Asset>
	{
		string last;
		public string Message { get { return last; } }

		private BindingList<string> History { get; set; }


		public AssetLog(Asset owner) : base(owner)
		{
			History = new BindingList<string>();
			last = String.Empty;
		}


		public void Entry(string message)
		{
			if (String.IsNullOrWhiteSpace(message) == false)
			{
				History.Add(String.Concat("Time [", DateTime.Now.ToUniversalTime(), "] Message: ", message));
			}
			last = message;
		}


	}
}
