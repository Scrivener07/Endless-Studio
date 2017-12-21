using ES2.Amplitude.Unity.Runtime;
using ES2.Amplitude.Unity.Runtime.Plugins;
using ES2.Editor.Assets;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

			try
			{
				if (Modification != null)
				{
					Modification.Read(progress); // deserialize
					if (Modification.Xml.FirstOrDefault().Value is RuntimeModule runtimeModule)
					{
						List<TableFile> allocated = new List<TableFile>();

						foreach (var plugin in runtimeModule.Plugins)
						{
							if (plugin is AIPlugin aiPlugin)
							{
								Trace.WriteLine(string.Format("{0} has AI contributions. Plugin[Priority:{1}, Configuration:{2}, AssemblyPath:{3}]", runtimeModule.Name, aiPlugin.Priority, aiPlugin.Configuration, aiPlugin.AssemblyPath));
							}
							else if (plugin is RegistryPlugin registryPlugin)
							{
								Trace.WriteLine(string.Format("{0} has registry contributions. Plugin[Priority:{1}, FilePath:{2}]", runtimeModule.Name, registryPlugin.Priority, registryPlugin.FilePath));
							}
							else if (plugin is LocalizationPlugin localizationPlugin)
							{
								Trace.WriteLine(string.Format("{0} has localization contributions. Plugin[Priority:{1}, DefaultLanguage:{2}, Directory:{3}]", runtimeModule.Name, localizationPlugin.Priority, localizationPlugin.DefaultLanguage, localizationPlugin.Directory));
							}
							else if (plugin is DatabasePlugin databasePlugin)
							{
								Trace.WriteLine(string.Format("{0} has database contributions. Plugin[Priority:{1}, FilePath:{2}, DataType:{3}, ExtraTypes:{4}]", runtimeModule.Name, databasePlugin.Priority, databasePlugin.FilePath, databasePlugin.DataType, databasePlugin.ExtraTypes));

								foreach (var pattern in databasePlugin.FilePath)
								{
									string filePattern = pattern.Replace(Environment.NewLine, String.Empty).Replace("/", "\\").Trim();

									//string relDirectory = Path.GetDirectoryName(filePattern);
									string relFile = Path.GetFileName(filePattern);

									string fullPath = Path.Combine(FolderPath, filePattern);
									string fullDirectoryPath = Path.GetDirectoryName(fullPath);

									if (Directory.Exists(fullDirectoryPath))
									{
										var files = Directory.GetFiles(fullDirectoryPath, relFile);
										foreach (var file in files)
										{
											TableFile asset = new TableFile(this, fullPath);
											allocated.Add(asset);
											Report.Progress(progress, Report.Message("Index, allocated file: " + asset.FilePath, MessageIcon.InformationB));
										}
									}
									else
									{
										Report.Progress(progress, Report.Message("Index, directory does not exist: " + fullDirectoryPath, MessageIcon.Warning));
									}
								}
							}
							else
							{
								throw new InvalidOperationException("Unexpected runtime plugin.");
							}
						}

						allocated.Where(asset => Tables.Contains(asset) == false).ToList()
							.ForEach(asset => Tables.Add(asset));
					}

					return true; // COMPELTED
				}
				else
				{
					Report.Progress(progress, Report.Message("A modification index containing a RuntimeModule could not be found.", MessageIcon.Error));
					return false;
				}
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
			}

			throw new NotImplementedException("The 'Allocate' method is not implemented yet.");
		}


		public async Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Allocate(progress));
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
