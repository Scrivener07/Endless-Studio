using ES2.Amplitude.Unity.Runtime;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Studio.Framework
{
	public static class Extensions
	{
		public const string ConnectionString = "DBConnectionString";


		#region EntityContext

		public static void ClearTables(this EntityContext context)
		{
			context.GetTables().ForEach(table => table.Clear());
		}


		public static void SeedTables(this EntityContext context)
		{
			context.GetTables().ForEach(table => table.Add(table.Create()));
		}


		public static List<DbSet> GetTables(this EntityContext context)
		{
			return new List<DbSet>
			{
				context.RuntimeModules,
	//			context.RuntimePlugins,
				//context.Tags,
				//context.QuestDefinitions,
				//context.TutorialDefinitions,
				//context.BasicFactions,
				//context.Factions,
				//context.FactionAffinitys,
				//context.FactionAffinityMappings,
				//context.FactionPopulationTraits,
				//context.FactionTraits,
				//context.FactionTraitCategoryDefinitions,
				//context.FactionTraitStartingSenates,
				//context.LesserFactions,
				//context.MajorFactions,
				//context.MinorFactions,
				//context.PirateFactions
			};
		}

		#endregion


		#region DbContext

		public static List<string> GetTableNames(this DbContext context)
		{
			return context.GetType().GetProperties()
				.Where(x => x.PropertyType.Name == "DbSet`1")
				.Select(x => x.Name).ToList();
		}

		#endregion


		#region DbSet

		/// <summary>
		/// Does not call save on context.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dbSet"></param>
		public static void Clear<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}


		/// <summary>
		/// Does not call save on context.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dbSet"></param>
		public static void Clear(this DbSet dbSet)
		{
			dbSet.RemoveRange(dbSet);
		}

		#endregion


		#region RuntimeModule

		public static void Serialize(this RuntimeModule runtimeModule, string path)
		{
			XmlSerializerNamespaces EmptyNameSpace = new XmlSerializerNamespaces();
			EmptyNameSpace.Add("", "");
			string file = Path.Combine(path, runtimeModule.Name + ".xml");
			StreamWriter stream = new StreamWriter(file);
			XmlSerializer serializer = new XmlSerializer(typeof(RuntimeModule));
			serializer.Serialize(stream, runtimeModule, EmptyNameSpace);
			stream.Close();
		}

		#endregion


	}
}
