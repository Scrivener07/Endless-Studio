using Microsoft.Win32;
using Sharp.Storage;
using System.ComponentModel;
using System.IO;

namespace ES2.Editor.Assets
{
	public class SteamFolder : FolderAsset
	{
		[DisplayName("EndlessSpace2.exe")]
		[Description("The Endless Space 2 game executable.")]
		public FileAsset Executable { get; private set; }

		[Description("The Endless Space 2 data folder.")]
		public string Data { get { return Path.Combine(URI, "EndlessSpace2_Data"); } }

		[Description("The Endless Space 2 public data folder.")]
		public string Public { get { return Path.Combine(URI, "Public"); } }


		public SteamFolder() : base(AutoDetect())
		{
			Executable = GetExecutable();
		}

		public SteamFolder(string directory) : base(directory)
		{
			Executable = GetExecutable();
		}


		private FileAsset GetExecutable()
		{
			return new FileAsset(Path.Combine(FolderPath, "EndlessSpace2.exe"));
		}


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
