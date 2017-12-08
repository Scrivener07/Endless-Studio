using Sharp.Applications.Storage;
using System;
using System.IO;

namespace ES2.Editor.Assets
{
	public class UserFolder : FolderAsset
	{
		public string Mods { get { return Path.Combine(Location, "Modding"); } }
		public string ModsXp { get { return Path.Combine(Location, "Disharmony", "Modding"); } }
		public string Editor { get { return Path.Combine(Location, "Editor"); } }

		public UserFolder() : base(AutoDetect()) { }
		public UserFolder(string location) : base(location) { }


		public static string AutoDetect()
		{
			string mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			return Path.Combine(mydocs, "Endless Space");
		}


	}
}
