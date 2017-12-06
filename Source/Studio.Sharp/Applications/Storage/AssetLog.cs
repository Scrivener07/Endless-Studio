using Sharp.Applications;
using System;
using System.ComponentModel;

namespace Sharp.Applications.Storage
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class AssetLog : ObjectComponent<Asset>
	{
		public string Message { get { return current; } }
		string current;

		private BindingList<string> History { get; set; }


		public AssetLog(Asset owner) : base(owner)
		{
			History = new BindingList<string>();
			current = String.Empty;
		}


		public void Entry(string message)
		{
			if (String.IsNullOrWhiteSpace(message) == false)
			{
				History.Add(String.Concat("Time [", DateTime.Now.ToUniversalTime(), "] Message: ", message));
			}

			current = message;
		}


	}
}
