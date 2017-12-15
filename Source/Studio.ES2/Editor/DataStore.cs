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

// TODO: Ensure that all runtime modules are deserialized before any tables.

namespace ES2.Editor
{
	public class DataStore : FolderAsset, IDataStore
	{
		ModificationAsset ModificationAsset;
		BindingList<TableAsset> TableAssets;


		public DataStore(string directory) : base(directory)
		{
			ModificationAsset = new ModificationAsset(Path.Combine(FolderPath, "index.xml"));
			TableAssets = new BindingList<TableAsset>();
		}


		#region IDataStore

		// TODO: Allocation needs to invalidate previous allocations!
		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				List<TableAsset> assets = new List<TableAsset>();

				// TODO: Allocation queries may be a bit abusive.
				Info.GetFiles("*.xml", SearchOption.AllDirectories).ToList()
					.ForEach(file => assets.Add(new TableAsset(this, file.FullName)));

				assets.Where(asset => TableAssets.Contains(asset) == false).ToList()
					.ForEach(asset => TableAssets.Add(asset));

				success = true;
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(MessageFormat.GetWarning(exception), MessageIcon.Error));
			}
			return success;
		}
		public async Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Allocate(progress));
		}


		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				TableAssets.ToList().ForEach(tableAsset => ImportAsset(tableAsset, progress));
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


		public void Reset()
		{
			throw new NotImplementedException("Reseting data stores is not yet suported.");
		}

		#endregion


		#region Datatables

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
								meta.Comments.Add("I updated my entity comment from " + ModificationAsset.ModName);

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

										var msg = "Dropped the entity '" + entity.Name + "' from " + ModificationAsset.ModName
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
