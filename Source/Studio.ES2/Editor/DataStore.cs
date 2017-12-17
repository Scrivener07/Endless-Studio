using ES2.Editor.Assets;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

// TODO: Ensure that all runtime modules are deserialized before any tables.

namespace ES2.Editor
{
	public class DataStore : FolderAsset, IDataStore
	{
		ModificationAsset Modification;
		BindingList<TableAsset> Tables;


		public DataStore(string directory) : base(directory)
		{
			Tables = new BindingList<TableAsset>();
		}


		#region IDataStore

		/// <summary>
		/// Allocates the files on disk for import.
		/// </summary>
		/// <param name="progress"></param>
		/// <returns></returns>
		/// <remarks>TODO: Allocation needs to invalidate previous allocations!</remarks>
		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			Tables.Clear();
			Modification = null;

			try
			{
				var topFiles = Info.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
					.Where(file => !String.Equals(file.Name, "Registry.xml", StringComparison.OrdinalIgnoreCase));

				foreach (var file in topFiles)
				{
					var xml = XDocument.Load(file.FullName);
					if (xml.Root.Descendants("RuntimeModule").ToList().Count == 1)
					{
						Modification = new ModificationAsset(this, file.FullName);
						Report.Progress(progress, Report.Message("A modification index was allocated at " + Modification.FilePath, MessageIcon.CompleteB));
						break;
					}
				}

				if (Modification != null) // A modification file was allocated.
				{
					// Find all xml files recursively in the data store directory.
					var files = Info.GetFiles("*.xml", SearchOption.AllDirectories)
						.Where(file => !String.Equals(file.Name, "Registry.xml", StringComparison.OrdinalIgnoreCase))
						.Where(file => !String.Equals(file.FullName, Modification.FilePath, StringComparison.OrdinalIgnoreCase));

					List<TableAsset> allocated = new List<TableAsset>();
					foreach (var file in files)
					{
						TableAsset asset = new TableAsset(this, file.FullName);
						allocated.Add(asset);
					}

					allocated.Where(asset => Tables.Contains(asset) == false).ToList()
						.ForEach(asset => Tables.Add(asset));

					return true;
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
			return false;
		}
		public async Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Allocate(progress));
		}

		/// <summary>
		/// Imports assets from xml on disk into the database.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on completion.</returns>
		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				ImportAsset(Modification, progress);
				Tables.ToList().ForEach(tableAsset => ImportAsset(tableAsset, progress));
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
		/// <param name="progress"></param>
		/// <returns></returns>
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


		#region DataStore

		private void ImportAsset(TableAsset file, IProgress<ProgressEventArgs> progress = null)
		{
			if (file == null) { Report.Progress(progress, Report.Message("Cannot import null table asset, skipping.", MessageIcon.Warning)); return; }
			try
			{
				if (file.Read(progress) && !file.IsNull && file.Xml.Count > 0)
				{
					// Reading the xml file was a success
					// The xml file also contained viable elements to import.
					// Continue with trying to import these elements into the database context.

					try
					{
						using (var context = new EntityContext())
						{
							// Iterate over the datatable elements.
							foreach (var kvp in file.Xml)
							{
								EntityType entity = kvp.Value; // for syntax

								// Create meta data for this entity.
								EntityTypeMeta meta = new EntityTypeMeta();
								meta.TableStack.Push(file.Xml);
								meta.Comments.Add("I updated my entity comment from " + Modification.FileName);

								// Get the DbSet for the entities type and load it.
								DbSet dbset = context.Set(entity.GetType());
								dbset.Load();


								if (dbset != null) // The database set was successfully retrieved.
								{
									Trace.WriteLine("Checking database for existing '" + entity.Name + "' entity.");
									var found = dbset.Find(entity.Name);


									if (found == null) // No entity by this name already exists.
									{
										// Set the entities meta data.
										meta.TableStack.Push(file.Xml);
										meta.Comments.Add("Created by " + file.FilePath);
										context.Entry(entity).Entity.SetMeta(meta);
										context.Entry(entity).State = EntityState.Added;
										context.SaveChanges();
									}
									else if (found is EntityType) // An entity with this name already exists!
									{
										// modify the existing entity in the database.
										var existing = found as EntityType;
										var existingMeta = existing.GetMeta();
										existingMeta.TableStack.Push(file.Xml);
										existingMeta.Comments.Add("Overriding an existing entity..");
										context.Entry(existing).State = EntityState.Modified;
										context.SaveChanges();

										var msg = "Dropped the entity '" + entity.Name + "' from " + Modification.FileName
												+ " because it is overridden by an entity in " + existingMeta.GetTablePath();

										var arg = Report.Message(msg, MessageIcon.InformationB);
										Report.Progress(progress, arg);
									}



									else // Something unexpected happend!
									{
										Report.Progress(progress, Report.Message("Ignored the entity '" + entity.Name + "'", MessageIcon.Warning));
									}
								}
								else
								{
									Report.Progress(progress, Report.Message("The DbSet for entity '" + entity.Name + "' count not be found.", MessageIcon.Warning));
								}
							}
							context.SaveChanges();
						}
					}
					catch (DbUpdateException exception)
					{
						var message1 = MessageFormat.GetWarning(exception);
						var message2 = String.Empty;

						if (exception.InnerException != null)
						{
							message2 = MessageFormat.GetWarning(exception.InnerException);
						}
						Report.Progress(progress, Report.Message("Entity Framework Exception: " + message1 + message2, MessageIcon.Error));
					}
				}
			}
			catch (Exception exception)
			{
				var message = MessageFormat.GetWarning(exception);
				Report.Progress(progress, Report.Message("Exception: '" + message + "', File Message: '" + file.Logs.Message + "'", MessageIcon.Error));
			}
		}

		#endregion


	}
}
