using System.ComponentModel;


namespace Sharp.Applications.Storage
{
	public class FolderAsset : Asset
	{
		[DisplayName("Folder")]
		public override string Key { get { return Location; } }



		public FolderAsset() : base()
		{

		}

		public FolderAsset(string directory) : base(directory)
		{

		}


	}
}
