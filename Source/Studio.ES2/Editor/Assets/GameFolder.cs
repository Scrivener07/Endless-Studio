using Microsoft.Win32;
using Sharp.Applications.Storage;
using System.IO;

namespace ES2.Editor.Assets
{
	public class GameFolder : FolderAsset
	{
		public string Public { get { return Path.Combine(Location, "Public"); } }
		public string Data { get { return Path.Combine(Location, "EndlessSpace2_Data"); } }

		public GameFolder() : base(AutoDetect()) { }
		public GameFolder(string location) : base(location) { }


		public static string AutoDetect()
		{
			RegistryKey key = Registry.CurrentUser;
			key = key.OpenSubKey("Software\\Valve\\Steam");
			if (key != null)
			{
				string value = key.GetValue("SteamPath").ToString();
				string result = Path.Combine(value, "SteamApps", "common", "Endless Space 2");
				return result;
			}
			return null;
		}


	}
}
