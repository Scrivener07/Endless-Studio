using ES2.Editor.Assets;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp;
using Sharp.Applications;
using Sharp.Applications.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES2.Editor
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ProjectModule : ObjectComponent<ProjectContext>, IProject, IDataStore
	{
		// Assets
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ModificationAsset DataManagerIndex { get; set; }


		public BindingList<TableAsset> FactionRepository { get; private set; }


		public BindingList<TableAsset> FactionTraits { get; private set; }



		// Dependencies
		public ProjectModule DependenciesSource { get; private set; }

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BindingList<ProjectModule> DependenciesMerged { get; private set; }

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool DependenciesHasSource { get { return DependenciesSource != null; } }

		// Simulations
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string SimulationComponentExportLocation { get { return Path.Combine(DataManagerIndex.Location, "Export"); } }

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Err_HasNoXml { get { return "Modification xml is null for " + DataManagerIndex.GetName() + ", consider calling read first."; } }

		// State
		public ProjectState State { get; private set; }

		public delegate void EventHandler();
		public event EventHandler<ProjectUpdatedEventArgs> EventUpdated;

		List<string> DataManagerAttemptedFiles = new List<string>();


		public ProjectModule(ProjectContext project) : base(project)
		{
			State = ProjectState.Unloaded;
			DataManagerIndex = new ModificationAsset();
			FactionRepository = new BindingList<TableAsset>();
			FactionTraits = new BindingList<TableAsset>();
			DependenciesSource = null;
			DependenciesMerged = new BindingList<ProjectModule>();
		}


		#region IProject

		/// <summary>
		/// Will allocate the project model from an index file.
		/// </summary>
		/// <param name="filepath">The path to an index file.</param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool Open(string filepath, IProgress<ProgressEventArgs> progress = null)
		{
			if (State == ProjectState.Unloaded)
			{
				DataManagerIndex = new ModificationAsset(filepath);

				if (DataManagerIndex.Read(progress))
				{
					if (true)
					{ // TODO: eliminate duplicated code, post flatten
						if (DataManagerIndex.HasXml == false)
						{
							Report.Progress(progress, Report.Message("Simulation allocation failed to start for " + DataManagerIndex.GetName(), DisplayIcon.Error));
							return Report.Failed;
						}

						if (DataManagerIndex.HasXml == false)
						{
							Report.Progress(progress, Report.Message(GetType().Name + " allocation failed.", DisplayIcon.Error));
							return Report.Failed;
						}
					}


					FactionComponentReset();


					DataManagerIndex.Xml.Game.Repositories
							.Where(repository => repository.Target.Equals("Faction")).ToList()
							.ForEach(repository => repository.Files.ToList()
							.ForEach(file => FactionRepository.Add(new TableAsset(DataManagerIndex.GetResolvedPath(file)))));

					DataManagerIndex.Xml.Game.Repositories
						.Where(repository => repository.Target.Equals("FactionTrait")).ToList()
						.ForEach(repository => repository.Files.ToList()
						.ForEach(file => FactionTraits.Add(new TableAsset(DataManagerIndex.GetResolvedPath(file)))));

					DependenciesAllocate(progress);

					State = ProjectState.Ready;
					InvokeUpdate();
					return true;
				}
				else
				{
					Unload();
					Report.Progress(progress, Report.Message("Could not open the modification. " + filepath, DisplayIcon.Error));
					return false;
				}
			}
			else
			{
				if (Unload())
					return Open(filepath, progress); // try again
				else
					return false;
			}
		}


		/// <summary>
		/// Allocates a new modification at the provided directory.
		/// </summary>
		/// <param name="directory"></param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool New(string directory, IProgress<ProgressEventArgs> progress = null)
		{
			if (State == ProjectState.Unloaded)
			{
				if (SharpIO.IsDirectoryEmpty(directory) == false)
				{
					if (MessageBox.Show("Warning, the selected directory is not empty. Continue anyway?", "", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						return false;
					}
				}
				DataManagerIndex = new ModificationAsset(Path.Combine(directory, "index.xml"));
				DataManagerIndex.Xml = new Amplitude.Unity.Runtime.RuntimeModule() { Name = new DirectoryInfo(DataManagerIndex.Location).Name };
				DependenciesAllocate(progress);
				InvokeUpdate();
				return true;
			}
			else
			{
				if (Unload())
				{
					return New(directory, progress);
				}
				else
				{
					return false;
				}
			}
		}


		public bool Unload()
		{
			if (State == ProjectState.Unloaded)
			{
				return true;
			}
			else
			{
				if (MessageBox.Show("Would you like to unload the current project?", "Unload", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					Reset();
					//DataManagerReset();
					//DependenciesReset();
					DataManagerUnload();
					State = ProjectState.Unloaded;
					InvokeUpdate();
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		#endregion


		#region IDataStore

		public void Reset()
		{
			DependenciesSource = null;
			DependenciesMerged = new BindingList<ProjectModule>();
			DataManagerIndex = new ModificationAsset();
			FactionComponentReset();
			DataManagerAttemptedFiles.Clear();
		}


		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException();
		}

		public Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException();
		}


		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{

			if (State == ProjectState.Ready)
			{
				// TODO:
			}

			if (DataManagerIndex.HasXml)
			{
				DataManagerImport(progress);
				DependenciesImport(progress);
				State = ProjectState.Loaded;
				return true;
			}
			else
			{
				DataManagerIndex.Logs.Entry(Err_HasNoXml);
				Report.Progress(progress, Report.Message(Err_HasNoXml, DisplayIcon.Error));
				return false;
			}
		}

		public async Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Import(progress));
		}


		public bool Export(IProgress<ProgressEventArgs> progress = null)
		{
			return DataManagerExport(progress);
		}

		public async Task<bool> ExportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Export(progress));
		}

		#endregion


		#region DataStores

		private bool DependenciesAllocate(IProgress<ProgressEventArgs> progress = null)
		{
			if (DataManagerIndex.HasXml)
			{
				if (DataManagerIndex.Xml.Game.Standalone == false)
				{
					DependenciesSource = new ProjectModule(Owner);

					if (DataManagerIndex.Xml.Game.RequestedDLCName == Index.DLC.Vanilla)
					{
						Report.Progress(progress, Report.Message("Detected a vanillia source dependency."));
						string path = Owner.Game.Public + @"\index.xml";

						if (DependenciesSource.Open(path, progress))
						{
							return true;
						}
						else
						{
							Report.Progress(progress, Report.Message("Could not auto find the dependency at " + path, DisplayIcon.Error));
							DependenciesSource = null;
							return false;
						}
					}
					//else if (DataManagerIndex.Xml.Game.RequestedDLCName == Index.DLC.Disharmony)
					//{
					//	Report.Progress(progress, Report.Message("Detected a disharmony source dependency."));
					//	string path = Owner.Game.PublicXp + @"\index.xml";

					//	if (DependenciesSource.Open(path, progress))
					//	{
					//		return true;
					//	}
					//	else
					//	{
					//		Report.Progress(progress, Report.Message("Could not auto find the dependency at " + path, DisplayIcon.Error));
					//		DependenciesSource = null;
					//		return false;
					//	}
					//}
					else
					{
						Report.Progress(progress, Report.Message("The requested dlc is unknown. " + DataManagerIndex.Xml.Game.RequestedDLCName, DisplayIcon.Error));
						DependenciesSource = null;
						return false;
					}
				}
				else
				{
					Report.Progress(progress, Report.Message(GetName() + " is standalone and has no further dependency.", DisplayIcon.Information));
					DependenciesSource = null;
					return true;
				}
			}
			else
			{
				Report.Progress(progress, Report.Message("Could not allocate dependency because the owner is not deserialized.", DisplayIcon.Error));
				DependenciesSource = null;
				return false;
			}
		}


		private void DependenciesImport(IProgress<ProgressEventArgs> progress = null)
		{
			if (DependenciesHasSource && DependenciesSource.DataManagerIndex.HasXml)
			{
				DependenciesSource.Import(progress);
				DependenciesMerged.ToList().ForEach(mod => mod.Import(progress));
			}
		}


		private bool DataManagerImport(IProgress<ProgressEventArgs> progress = null)
		{
			Report.Progress(progress, Report.Message("Import started by " + DataManagerIndex.GetName(), DisplayIcon.Information));

			DataManagerAttemptedFiles.Clear();
			bool complete = SimulationComponentImport(progress);
			DataManagerAttemptedFiles.Clear();

			return complete;
		}


		private bool DataManagerExport(IProgress<ProgressEventArgs> progress = null)
		{
			return SimulationComponentExport();
		}



		private bool SimulationComponentImport(IProgress<ProgressEventArgs> progress = null)
		{
			FactionComponentImport(progress);
			return true;
		}


		private bool SimulationComponentExport(IProgress<ProgressEventArgs> progress = null)
		{
			FactionComponentExport(progress);
			return true;
		}

		/// <summary>
		/// Used by FactionComponentAllocate
		/// </summary>
		private void FactionComponentReset()
		{
			FactionRepository.Clear();
			FactionTraits.Clear();
		}





		private bool FactionComponentImport(IProgress<ProgressEventArgs> progress = null)
		{
			FactionRepository.ToList().ForEach(file => DataManagerImportFile(file, progress));
			FactionTraits.ToList().ForEach(file => DataManagerImportFile(file, progress));
			return true;
		}


		private bool FactionComponentExport(IProgress<ProgressEventArgs> progress = null)
		{
			if (DataManagerIndex != null && Directory.Exists(SimulationComponentExportLocation))
			{
				FactionComponentExportFactions(progress);
				FactionComponentExportTraits(progress);
				return true;
			}
			return false;
		}


		#endregion


		#region Methods

		public void DependenciesSetSource(string filepath, IProgress<ProgressEventArgs> progress = null)
		{
			var modification = new ModificationAsset(filepath);

			if (modification.Exists && modification.HasFormat)
			{
				if (modification.Read() && modification.HasXml && modification.Xml.Game.Standalone)
				{
					if (modification.Xml.Game.RequestedDLCName == DataManagerIndex.Xml.Game.RequestedDLCName)
					{
						DependenciesSource = new ProjectModule(Owner)
						{
							DataManagerIndex = modification
						};
						Report.Progress(progress, Report.Message("Set the source dependency. " + filepath, DisplayIcon.Complete));
						return;
					}
				}
			}
			Report.Progress(progress, Report.Message("Could not set the source dependency. " + filepath, DisplayIcon.Error));
			DependenciesSource = null;
		}


		private bool DataManagerUnload(IProgress<ProgressEventArgs> progress = null)
		{
			try
			{
				using (var context = new EntityContext())
				{
					context.ClearTables();
					int deletions = context.SaveChanges();
					Report.Progress(progress, Report.Message("Unloaded " + deletions + " entities from the simulation context.", DisplayIcon.Information));
					return true;
				}
			}
			catch (Exception exception)
			{
				Report.Progress(progress, Report.Message("Exception: '" + ExceptionMessage.GetWarning(exception), DisplayIcon.Error));
				return false;
			}
		}


		private void DataManagerImportFile(TableAsset file, IProgress<ProgressEventArgs> progress = null)
		{
			try
			{
				if (file != null)
				{
					if (!DataManagerAttemptedFiles.Contains(file.FilePath))
					{
						DataManagerAttemptedFiles.Add(file.FilePath);

						if (file.Read(progress) && file.HasXml && file.Xml.Count > 0)
						{
							DataManagerProcessFile(file, progress);
						}
					}
				}
			}
			catch (Exception exception)
			{
				var message = ExceptionMessage.GetWarning(exception);
				Report.Progress(progress, Report.Message("Exception: '" + message + "', File Message: '" + file.Logs.Message + "'", DisplayIcon.Error));
			}
		}


		private void DataManagerProcessFile(TableAsset file, IProgress<ProgressEventArgs> progress = null)
		{
			try
			{
				if (file != null && file.HasXml)
				{
					using (var context = new EntityContext())
					{
						foreach (var kvp in file.Xml)
						{
							kvp.Value.Meta.Location = file.FilePath;
							DataManagerProcessEntity(kvp.Value, context, progress);
						}
						context.SaveChanges();
					}
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


		private void DataManagerProcessEntity(EntityType entity, EntityContext context, IProgress<ProgressEventArgs> progress = null)
		{
			string currentMod = DataManagerIndex.GetName();


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
					DataManagerUpdateMeta(entity, context);
					//---------------------------------------------
					context.Entry(entity).State = EntityState.Added;
					context.SaveChanges();

				}
				else if (found is EntityType)
				{
					var existing = found as EntityType;
					existing.Meta.TextList.Add(new TextData() { Text = currentMod });
					//---------------------------------------------
					DataManagerUpdateMeta(existing, context);
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


		private void DataManagerUpdateMeta(EntityType entity, EntityContext context)
		{
			string currentMod = DataManagerIndex.GetName();

			entity.Meta.Comment = "I updated my entity comment from " + currentMod;
			entity.Meta.NameStack.Push(currentMod);
			entity.Meta.Dependencies[1] = currentMod;
			entity.Meta.TextList.Add(new TextData() { Text = currentMod });

			// Mod info
			entity.DependencyList.Add(new MetaInfo() { Mod = currentMod, File = DataManagerIndex.Location });
		}


		private bool SimulationComponentSaveFile(TableAsset asset, IProgress<ProgressEventArgs> progress = null)
		{
			if (asset != null && asset.HasXml && asset.Xml.Count > 0 && asset.Write())
			{
				asset.OpenInSystem();
				return true;
			}

			return false;
		}


		private bool FactionComponentExportFactions(IProgress<ProgressEventArgs> progress = null)
		{
			var repoName = "Faction";
			string filepath = Path.Combine(SimulationComponentExportLocation, repoName + ".xml");
			TableAsset file = new TableAsset(filepath) { Xml = new Datatable() };

			using (var context = new EntityContext())
			{
				var query = context.Factions.Where(entity => entity.Meta.Owner.Equals(DataManagerIndex.Xml.Name));
				query.ToList().ForEach(entity => file.Xml.Add(entity.Name, entity));
			}

			return SimulationComponentSaveFile(file);
		}


		private bool FactionComponentExportTraits(IProgress<ProgressEventArgs> progress = null)
		{
			var repoName = "FactionTrait";
			string filepath = Path.Combine(SimulationComponentExportLocation, repoName + ".xml");
			TableAsset file = new TableAsset(filepath) { Xml = new Datatable() };

			using (var context = new EntityContext())
			{
				var query = context.FactionTraits.Where(entity => entity.Meta.Owner.Equals(DataManagerIndex.Xml.Name));
				query.ToList().ForEach(entity => file.Xml.Add(entity.Name, entity));
			}

			return SimulationComponentSaveFile(file);
		}


		public void InvokeUpdate()
		{
			EventUpdated?.Invoke(null, new ProjectUpdatedEventArgs(State, DataManagerIndex));
		}


		public string GetName()
		{
			return DataManagerIndex.GetName();
		}


		public override string ToString()
		{
			return "Project " + State.ToString();
		}


		private string SimulationComponentToString()
		{
			return "Simulations..";
		}


		private string FactionComponentToString()
		{
			return "Factions";
		}


		private string DataManagerToString()
		{
			if (DataManagerIndex == null)
			{
				return base.ToString();
			}
			return DataManagerIndex.GetName();
		}


		private string DependenciesToString()
		{
			if (DependenciesSource == null && DependenciesMerged == null)
			{
				return "No dependencies.";
			}
			int count = 0;
			if (DependenciesSource != null)
				count = 1;
			if (DependenciesMerged != null)
				count = count + DependenciesMerged.Count;
			return String.Concat(count, " dependencies.");
		}

		#endregion


	}
}
