using ES2.Editor.Assets;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ES2.Editor
{
	public class DataStore : FolderAsset, IDataStore, IDatabase
	{
		ModificationFile Modification;
		BindingList<TableFile> Tables;
		public string Index { get { return Modification.FileName; } }


		public DataStore(string directory) : base(directory)
		{
			Tables = new BindingList<TableFile>();
		}


		#region IDataStore

		/// <summary>
		/// Allocates the files on disk for import.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		/// TODO: Allocation needs to invalidate previous allocations!
		/// TODO: Only allocate tables defined in the modifications runtime plugins.
		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			if (AllocateModification(progress))
			{
				if (AllocateTables(progress))
				{
					return true;
				}
			}
			return false;
		}


		public async Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Allocate(progress));
		}


		private bool AllocateModification(IProgress<ProgressEventArgs> progress = null)
		{
			Modification = null;
			try
			{
				var files = GetXmlFiles(SearchOption.TopDirectoryOnly);
				foreach (var file in files)
				{
					var xml = XDocument.Load(file.FullName);
					int count = xml.Root.Descendants("RuntimeModule").Count();
					if (count == 1)
					{
						Modification = new ModificationFile(this, file.FullName);
						Report.Progress(progress, Report.Message("A modification index was allocated at " + Modification.FilePath, MessageIcon.CompleteB));
						break;
					}
				}
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
			}

			return Modification != null;
		}


		private bool AllocateTables(IProgress<ProgressEventArgs> progress = null)
		{
			Tables.Clear();
			if (Modification != null)
			{
				try
				{
					// Find all xml files recursively in the data store directory.
					var files = GetXmlFiles(SearchOption.AllDirectories)
						.Where(file => !String.Equals(file.FullName, Modification.FilePath, StringComparison.OrdinalIgnoreCase));

					List<TableFile> allocated = new List<TableFile>();

					foreach (var file in files)
					{
						TableFile asset = new TableFile(this, file.FullName);
						allocated.Add(asset);
					}

					allocated.Where(asset => Tables.Contains(asset) == false).ToList()
						.ForEach(asset => Tables.Add(asset));
				}
				catch (Exception exception)
				{
					Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
				}

				return true;
			}
			else
			{
				Report.Progress(progress, Report.Message("A modification index containing a RuntimeModule could not be found.", MessageIcon.Error));
				return false;
			}
		}


		/// <summary>
		/// Imports assets from xml on disk into the database.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{
			if (Modification == null)
			{
				Report.Progress(progress, Report.Message("Cannot import a null modification.", MessageIcon.Error));
				return false;
			}

			bool success = false;
			try
			{
				Modification.Import(progress);
				Tables.ToList().ForEach(file => file.Import(progress));
				success = true;
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
			}
			return success;
		}


		public async Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Import(progress));
		}


		/// <summary>
		/// Exports the database to xml assets on disk.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		public bool Export(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				using (var context = new EntityContext())
				{
					var tables = context.GetTables();
					foreach (var dbset in tables)
					{
						foreach (var entry in dbset)
						{
							if (entry is EntityType)
							{
								// TODO: exporting is not yet suported.

								//var entity = entry as EntityType;
								//entity.Meta.Asset.Write(progress);

								throw new NotImplementedException("Exporting data stores is not yet suported.");
							}
						}
					}
				}
				success = true;
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
			}
			return success;
		}
		public async Task<bool> ExportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Export(progress));
		}

		#endregion


		#region Queries

		public IEnumerable<FileInfo> GetXmlFiles(SearchOption search)
		{
			return Info.GetFiles("*.xml", search)
				.Where(file => !String.Equals(file.Name, "Registry.xml", StringComparison.OrdinalIgnoreCase));
		}

		#endregion


	}
}
