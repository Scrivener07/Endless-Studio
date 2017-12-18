using ES2.Editor.Framework;
using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage.Special;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ES2.Editor.Assets
{
	public class TableFile : XmlAsset<Datatable>, IDatabase
	{
		private readonly DataStore Data;
		public override Datatable Xml { get; protected set; }


		public TableFile(DataStore datastore, string filepath) : base(filepath)
		{
			Data = datastore ?? throw new ArgumentNullException("datastore", "The data store cannot be null.");
		}


		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{
			// Reading the xml file was a success.
			// The xml file also contained viable elements to import.
			// Continue with trying to import these elements into the database context.
			Read(progress);

			if (!IsNull && Xml.Count > 0)
			{
				try
				{
					using (var context = new EntityContext())
					{
						// Iterate over the datatable elements.
						foreach (var kvp in Xml)
						{
							EntityType entity = kvp.Value; // for syntax

							// Create meta data for this entity.
							EntityTypeMeta meta = new EntityTypeMeta();
							meta.TableStack.Push(Xml);
							meta.Comments.Add("I updated my entity comment from " + Data.Index);

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
									meta.TableStack.Push(Xml);
									meta.Comments.Add("Created by " + FilePath);
									context.Entry(entity).Entity.SetMeta(meta);
									context.Entry(entity).State = EntityState.Added;
									context.SaveChanges();
									continue;
								}
								else if (found is EntityType) // An entity with this name already exists!
								{
									// modify the existing entity in the database.
									var existing = found as EntityType;
									var existingMeta = existing.GetMeta();
									existingMeta.TableStack.Push(Xml);
									existingMeta.Comments.Add("Overriding an existing entity..");
									context.Entry(existing).State = EntityState.Modified;
									context.SaveChanges();

									var msg = "Dropped the entity '" + entity.Name + "' from " + Data.Index
											+ " because it is overridden by an entity in " + existingMeta.GetTablePath();

									var arg = Report.Message(msg, MessageIcon.InformationB);
									Report.Progress(progress, arg);
									continue;
								}
								else
								{
									Report.Progress(progress, Report.Message("Something unexpected happend. Ignored the entity '" + entity.Name + "'", MessageIcon.Warning));
									continue;
								}
							}
							else
							{
								Report.Progress(progress, Report.Message("The DbSet for entity '" + entity.Name + "' count not be found.", MessageIcon.Warning));
								continue;
							}
						}

						context.SaveChanges();
						return true;
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
				catch (Exception exception)
				{
					var message = MessageFormat.GetWarning(exception);
					Report.Progress(progress, Report.Message("Exception: '" + message + "', File Message: '" + Logs.Message + "'", MessageIcon.Error));
				}

				return false; // an exception was caught
			}
			else
			{
				Report.Progress(progress, Report.Message("The datatable was null or empty.", MessageIcon.Warning));
				return false;
			}
		}


		public async Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Import(progress));
		}


		#region XmlAsset

		protected override bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (!IsNull)
			{
				var message = "The file '" + FilePath + "' contains '" + Xml.Count + "' elements.";
				Logs.Entry(message);

				if (Xml.Count <= 0)
				{
					Report.Progress(progress, Report.Message(message, MessageIcon.Warning));
					return true;
				}
				else
				{
					Report.Progress(progress, Report.Message(message, MessageIcon.Complete));
					return true;
				}
			}
			else
			{
				var message = "The file '" + FilePath + "' could not be deserialized.";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Error));
				return false;
			}
		}

		#endregion


	}
}
