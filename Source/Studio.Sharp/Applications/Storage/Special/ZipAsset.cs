using Sharp.Applications.Messages;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;


namespace Sharp.Applications.Storage.Special
{
	public class ZipAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ext; } }
		const string ext = ".zip";


		public ZipAsset() : base()
		{
			// constructor
		}


		public ZipAsset(string filepath) : base(filepath)
		{
			// constructor
		}


		public ZipArchiveEntry[] GetEntries()
		{
			if (File.Exists(FilePath))
			{
				try
				{
					using (ZipArchive archive = ZipFile.Open(FilePath, ZipArchiveMode.Read))
					{
						foreach (ZipArchiveEntry entry in archive.Entries)
						{
							Trace.WriteLine("Name: " + entry.Name);
							Trace.WriteLine("Size: " + entry.CompressedLength);
							Trace.WriteLine("Last Write: " + entry.LastWriteTime);
							Trace.WriteLine("FullName: " + entry.FullName);
							Trace.WriteLine(String.Empty);
						}
						return archive.Entries.ToArray();
					}
				}
				catch (Exception exception)
				{
					this.Logs.Entry(ExceptionMessage.GetWarning(exception));
					throw;
				}
			}

			return null;
		}


	}
}
