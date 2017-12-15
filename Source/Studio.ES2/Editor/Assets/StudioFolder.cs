using Sharp.Storage;
using Sharp.Storage.Special;
using System.IO;
using System.Windows.Forms;

namespace ES2.Editor.Assets
{
	public class StudioFolder : FolderAsset
	{
		public string ContentDirectory { get { return Path.Combine(URI, "Content"); } }
		public ZipAsset ArchivePublic { get; private set; }


		public StudioFolder() : base(AutoDetect())
		{
			Construct();
		}


		public StudioFolder(string location) : base(location)
		{
			Construct();
		}


		private void Construct()
		{
			ArchivePublic = new ZipAsset(Path.Combine(ContentDirectory, "Public.zip"));
		}


		public static string AutoDetect()
		{
			return Application.StartupPath;
		}


	}
}
