using Sharp.Applications.Storage;
using System;
using System.IO;

namespace ES2.Editor.Assets
{
	public class UserFolder : FolderAsset
	{
		public string Mods { get { return Path.Combine(Location, "Community"); } }
		public string CustomFactions { get { return Path.Combine(Location, "Custom Factions"); } }
		public string ResourcesExport { get { return Path.Combine(Location, "Resources Export"); } }
		public string SaveFiles { get { return Path.Combine(Location, "Save Files"); } }
		public string Screenshots { get { return Path.Combine(Location, "screenshots"); } }
		public string TemporaryFiles { get { return Path.Combine(Location, "Temporary Files"); } }
		public string Users { get { return Path.Combine(Location, "Users"); } }

		public UserFolder() : base(AutoDetect()) { }
		public UserFolder(string location) : base(location) { }


		public static string AutoDetect()
		{
			string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			return Path.Combine(myDocuments, "Endless Space 2");
		}


	}
}
