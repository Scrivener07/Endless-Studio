using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Sharp.Applications.Storage
{
	[DebuggerStepThrough]
	public class FileAsset : Asset
	{
		[DisplayName("File")]
		public override string Key { get { return FilePath; } }
		public readonly string FilePath = null;


		public new string Location
		{
			get
			{
				try { return Path.GetDirectoryName(FilePath); }
				catch { return "The file directory could not found."; }
			}
		}

		public string FileName { get { return Path.GetFileName(FilePath); } }
		public override bool Exists { get { return File.Exists(FilePath); } }
		public bool HasFormat { get { return EvaluateFormat(FilePath); } }
		protected virtual string DefaultExtension { get { return Path.GetExtension(FilePath); } }


		public FileAsset() : base()
		{
			FilePath = Guid.NewGuid().ToString();
		}


		public FileAsset(string filepath) : base(filepath)
		{
			FilePath = filepath;

			if (EvaluateFormat(filepath) == false)
			{
				this.Logs.Entry("The asset has an incorrect path format.");
			}
		}


		/// <summary>
		/// Checks the FilePath matches the default file extension and is not empty, null, or whitespace.
		/// </summary>
		protected virtual bool EvaluateFormat(string filepath)
		{
			try { Path.GetFullPath(filepath); }
			catch { return false; }

			bool hasExtension = String.Equals(DefaultExtension, Path.GetExtension(filepath), StringComparison.OrdinalIgnoreCase);
			bool isRooted = Path.IsPathRooted(filepath);

			return hasExtension && isRooted;
		}


		public override string ToString()
		{
			return String.Concat(@"..\", this.FileName);
		}


	}
}
