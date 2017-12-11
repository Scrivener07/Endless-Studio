using Sharp.Storage;
using System;
using System.IO;

namespace ES2.Editor.Assets
{
	public class UserFolder : FolderAsset
	{
		public string Mods { get { return Path.Combine(URI, "Community"); } }
		public string CustomFactions { get { return Path.Combine(URI, "Custom Factions"); } }
		public string ResourcesExport { get { return Path.Combine(URI, "Resources Export"); } }
		public string SaveFiles { get { return Path.Combine(URI, "Save Files"); } }
		public string Screenshots { get { return Path.Combine(URI, "screenshots"); } }
		public string TemporaryFiles { get { return Path.Combine(URI, "Temporary Files"); } }
		public string Users { get { return Path.Combine(URI, "Users"); } }

		public UserFolder() : base(AutoDetect()) { }
		public UserFolder(string location) : base(location) { }


		public static string AutoDetect()
		{
			string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			return Path.Combine(myDocuments, "Endless Space 2");
		}


	}
}
