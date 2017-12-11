using Sharp.Reporting;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Sharp.Storage.Special
{
	public class ZipAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ".zip"; } }
		public ZipAsset(string filepath) : base(filepath) { }


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
					Logs.Entry(MessageFormat.GetWarning(exception));
					throw;
				}
			}

			return null;
		}


	}
}
