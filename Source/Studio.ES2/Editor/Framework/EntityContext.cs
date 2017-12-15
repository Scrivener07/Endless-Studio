using ES2.Amplitude.Unity.Localization;
using ES2.Amplitude.Unity.Runtime;
using ES2.Amplitude.Unity.Simulation;
using System.Collections.Generic;
using System.Data.Entity;

namespace ES2.Editor.Framework
{
	public class EntityContext : DbContext
	{
		private const string ConnectionString = "DBConnectionString";

		public DbSet<RuntimeModule> RuntimeModules { get; set; }
		public DbSet<Faction> Factions { get; set; }
		public DbSet<BasicFaction> BasicFactions { get; set; }
		public DbSet<LesserFaction> LesserFactions { get; set; }
		public DbSet<MajorFaction> MajorFactions { get; set; }
		public DbSet<MinorFaction> MinorFactions { get; set; }
		public DbSet<PirateFaction> PirateFactions { get; set; }
		public DbSet<FactionAffinity> FactionAffinitys { get; set; }
		public DbSet<FactionAffinityMapping> FactionAffinityMappings { get; set; }
		public DbSet<FactionPopulationTrait> FactionPopulationTraits { get; set; }
		public DbSet<FactionTrait> FactionTraits { get; set; }
		public DbSet<FactionTraitCategoryDefinition> FactionTraitCategoryDefinitions { get; set; }
		public DbSet<FactionTraitStartingSenate> FactionTraitStartingSenates { get; set; }
		public DbSet<LocalizationDatatableElement> LocalizationDatatableElements { get; set; }


		public EntityContext() : base(ConnectionString)
		{
			Database.SetInitializer(new EntityInitializer());
		}


		/// <summary>
		/// TODO: I think the list allocation in GetTables defeats the purpose of calling dbset.load?
		/// Syntax wise, its better than writing out Load() for each dbset
		/// </summary>
		public void LoadTables()
		{
			GetTables().ForEach(table => table.Load());
		}


		public void ClearTables()
		{
			FactionTraitStartingSenates.Clear();
			GetTables().ForEach(table => table.Clear());
		}


		public void SeedTables()
		{
			GetTables().ForEach(table => table.Add(table.Create()));
		}

		/// <summary>
		/// Gets a list of all DbSets within the context.
		/// </summary>
		/// <returns>A list of all DbSets within the context.</returns>
		public List<DbSet> GetTables()
		{
			return new List<DbSet>
			{
				RuntimeModules,
				Factions,
				BasicFactions,
				LesserFactions,
				MajorFactions,
				MinorFactions,
				PirateFactions,
				FactionAffinitys,
				FactionAffinityMappings,
				FactionPopulationTraits,
				FactionTraits,
				FactionTraitCategoryDefinitions,
				FactionTraitStartingSenates,
				LocalizationDatatableElements
			};
		}


	}
}
