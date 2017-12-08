using Sharp.Applications.Storage;
using Sharp.Applications.Storage.Special;
using System.IO;
using System.Windows.Forms;

namespace ES2.Editor.Assets
{
	public class AppFolder : FolderAsset
	{
		public string ContentDirectory { get { return Path.Combine(Location, "Content"); } }
		public ZipAsset ArchivePublic { get; private set; }
		public ZipAsset ArchivePublicXp { get; private set; }


		public AppFolder() : base(AutoDetect())
		{
			Construct();
		}


		public AppFolder(string location) : base(location)
		{
			Construct();
		}


		private void Construct()
		{
			ArchivePublic = new ZipAsset(Path.Combine(ContentDirectory, "Public.zip"));
			ArchivePublicXp = new ZipAsset(Path.Combine(ContentDirectory, "Public_xp1.zip"));
		}


		public static string AutoDetect()
		{
			return Application.StartupPath;
		}


	}
}
