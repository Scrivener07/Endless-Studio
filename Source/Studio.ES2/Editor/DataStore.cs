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

								throw new NotImplementedException("Exporting projects is not yet suported.");
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
			throw new NotImplementedException();
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
					try
					{
						using (var context = new EntityContext())
						{
							foreach (var kvp in file.Xml)
							{
								EntityType entity = kvp.Value;
								entity.Meta.Location = file.FilePath;

								// ---

								string currentMod = ModificationAsset.ToString();

								DbSet dbset = context.Set(entity.GetType());
								dbset.Load();


								if (dbset != null)
								{
									Debug.WriteLine("Finding the entity: " + entity.Name);
									var found = dbset.Find(entity.Name);


									if (found == null)
									{
										context.Entry(entity).Entity.Meta.Owner = currentMod;
										//---------------------------------------------
										UpdateMeta(entity, context);
										//---------------------------------------------
										context.Entry(entity).State = EntityState.Added;
										context.SaveChanges();

									}
									else if (found is EntityType)
									{
										var existing = found as EntityType;
										existing.Meta.TextList.Add(new TextData() { Text = currentMod });
										//---------------------------------------------
										UpdateMeta(existing, context);
										//---------------------------------------------

										context.Entry(existing).State = EntityState.Modified;
										context.Entry(existing).ComplexProperty("Meta").IsModified = true;
										context.SaveChanges();

										var msg = "Dropped the entity '" + entity.Name + "' from " + currentMod
												+ " because it is overridden by an entity in " + existing.Meta.Owner;

										var arg = Report.Message(msg, MessageIcon.InformationB);
										Report.Progress(progress, arg);
									}
									else
									{
										Report.Progress(progress, Report.Message("Ignored the entity '" + entity.Name + "'", MessageIcon.Warning));
									}
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

		// TODO: Refactor entity meta data.
		private void UpdateMeta(EntityType entity, EntityContext context)
		{
			string currentMod = ModificationAsset.ToString();

			entity.Meta.Comment = "I updated my entity comment from " + currentMod;
			entity.Meta.NameStack.Push(currentMod);
			entity.Meta.Dependencies[1] = currentMod;
			entity.Meta.TextList.Add(new TextData() { Text = currentMod });

			// Mod info
			entity.DependencyList.Add(new MetaInfo() { Mod = currentMod, File = ModificationAsset.FolderPath });
		}

		#endregion


	}
}
