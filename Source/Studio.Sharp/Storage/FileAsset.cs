using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Sharp.Storage
{
	[DebuggerStepThrough]
	public class FileAsset : Asset
	{
		protected readonly FileInfo Info;

		[DisplayName("Name")]
		public string FileName { get { return Info.Name; } }

		[DisplayName("File")]
		public virtual string FilePath { get { return Info.FullName; } }

		[DisplayName("Folder")]
		public string FolderPath { get { return Info.DirectoryName; } }

		[DisplayName("Exists")]
		public override bool Exists { get { return Info.Exists; } }

		[DisplayName("Extension")]
		protected string Extension { get { return Info.Extension; } }
		protected virtual string DefaultExtension { get { return null; } }


		public FileAsset(string filepath) : base(filepath)
		{
			Info = new FileInfo(URI);
		}


		public override string ToString()
		{
			return FileName;
		}


	}
}
