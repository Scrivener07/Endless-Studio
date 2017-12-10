using System.ComponentModel;
using System.Diagnostics;

namespace Sharp.Applications.Storage
{
	[DebuggerStepThrough]
	public class FolderAsset : Asset
	{
		[DisplayName("Folder")]
		public override string Key { get { return Location; } }


		public FolderAsset() : base() { }
		public FolderAsset(string directory) : base(directory) { }


	}
}
