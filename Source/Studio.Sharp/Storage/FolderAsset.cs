using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Sharp.Storage
{
	[DebuggerStepThrough]
	public class FolderAsset : Asset
	{
		protected readonly DirectoryInfo Info;

		[DisplayName("Folder")]
		public virtual string FolderPath { get { return URI; } }


		public FolderAsset(string directory) : base(directory)
		{
			Info = new DirectoryInfo(URI);
		}


		public override string ToString()
		{
			return FolderPath;
		}


	}
}
