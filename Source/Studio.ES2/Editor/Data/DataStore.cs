using ES2.Amplitude.Unity.Simulation;
using ES2.Editor.Assets;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp.Applications;
using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ES2.Editor
{
	public class DataStore : IDataStore
	{
		DirectoryInfo Info;
		ModificationAsset ModificationAsset;
		BindingList<TableAsset> TableAssets;


		public DataStore(string directory)
		{
			Info = new DirectoryInfo(directory);
			ModificationAsset = new ModificationAsset(Path.Combine(directory, "index.xml"));
			TableAssets = new BindingList<TableAsset>();
		}


		#region IDataStore

		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				Info.GetFiles("*.xml", SearchOption.AllDirectories)
					.ToList()
					.ForEach(file => TableAssets.Add(new TableAsset(file.FullName)));
				success = true;
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(ExceptionMessage.GetWarning(exception), DisplayIcon.Error));
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
				Report.Progress(progress, Report.Message(ExceptionMessage.GetWarning(exception), DisplayIcon.Error));
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
				MajorFaction faction = new MajorFaction()
				{
					Name = "Amarr"
				};

				Datatable datatable = new Datatable();
				datatable.Add(faction.Name, faction);

				TableAsset fileAsset = new TableAsset(Path.Combine(Info.FullName, "MyRepoName.xml"))
				{
					Xml = datatable
				};

				//TableAssets.Add(fileAsset);

				try
				{
					bool breakpoint = fileAsset.Write(progress);
					breakpoint.ToString(); // TODO: Delete this line, its for a break point only.
				}
				catch (Exception exception)
				{
					Report.Progress(progress, Report.Message(ExceptionMessage.GetWarning(exception), DisplayIcon.Error));
				}






				TableAssets.ToList().ForEach(tableAsset => ExportAsset(tableAsset, progress));
				success = true;
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message(ExceptionMessage.GetWarning(exception), DisplayIcon.Error));
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
			if (file == null) { Report.Progress(progress, Report.Message("Cannot import null table asset, skipping.", DisplayIcon.Warning)); return; }
			try
			{
				if (file.Read(progress) && file.HasXmlData && file.Xml.Count > 0)
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

								string currentMod = ModificationAsset.GetName();

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

										var arg = Report.Message(msg, DisplayIcon.InformationB);
										Report.Progress(progress, arg);
									}
									else
									{
										Report.Progress(progress, Report.Message("Ignored the entity '" + entity.Name + "'", DisplayIcon.Warning));
									}
								}
							}
							context.SaveChanges();
						}
					}
					catch (DbUpdateException exception)
					{
						var message1 = ExceptionMessage.GetWarning(exception);
						var message2 = String.Empty;

						if (exception.InnerException != null)
						{
							message2 = ExceptionMessage.GetWarning(exception.InnerException);
						}
						Report.Progress(progress, Report.Message("Entity Framework Exception: " + message1 + message2, DisplayIcon.Error));
					}
				}
			}
			catch (Exception exception)
			{
				var message = ExceptionMessage.GetWarning(exception);
				Report.Progress(progress, Report.Message("Exception: '" + message + "', File Message: '" + file.Logs.Message + "'", DisplayIcon.Error));
			}
		}


		private void UpdateMeta(EntityType entity, EntityContext context)
		{
			string currentMod = ModificationAsset.GetName();

			entity.Meta.Comment = "I updated my entity comment from " + currentMod;
			entity.Meta.NameStack.Push(currentMod);
			entity.Meta.Dependencies[1] = currentMod;
			entity.Meta.TextList.Add(new TextData() { Text = currentMod });

			// Mod info
			entity.DependencyList.Add(new MetaInfo() { Mod = currentMod, File = ModificationAsset.Location });
		}



		private bool ExportAsset(TableAsset file, IProgress<ProgressEventArgs> progress = null)
		{
			using (var context = new EntityContext())
			{
				context.Factions
					.Where(entity => entity.Meta.Owner.Equals(ModificationAsset.Xml.Name)).ToList()
					.ForEach(entity => file.Xml.Add(entity.Name, entity));
			}

			return SaveFile(file);
		}


		public bool SaveFile(TableAsset asset, IProgress<ProgressEventArgs> progress = null)
		{
			if (asset != null && asset.HasXmlData && asset.HasXmlElements && asset.Write())
			{
				asset.Open();
				return true;
			}

			return false;
		}


		#endregion


	}
}
