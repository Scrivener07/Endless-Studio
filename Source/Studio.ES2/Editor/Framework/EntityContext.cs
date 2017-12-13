using ES2.Amplitude.Unity.Localization;
using ES2.Amplitude.Unity.Runtime;
using ES2.Amplitude.Unity.Simulation;
using ES2.Editor.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;

namespace ES2.Editor.Framework
{
	public class EntityContext : DbContext
	{
		private const string ConnectionString = "DBConnectionString";

		/// <summary>
		/// Each entity must store its type within the element cache. 
		/// Store the type in the entities static constructor or use the annotation attribute.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public static TypeDictionary Serializer { get; private set; }

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


		static EntityContext()
		{
			Serializer = new TypeDictionary();
			Serializer.Initialize(typeof(RuntimeModule));
			Serializer.Initialize(typeof(QuestDefinition));
			Serializer.Initialize(typeof(TutorialDefinition));
			Serializer.Initialize(typeof(BasicFaction));
			Serializer.Initialize(typeof(FactionAffinity));
			Serializer.Initialize(typeof(FactionAffinityMapping));
			Serializer.Initialize(typeof(FactionPopulationTrait));
			Serializer.Initialize(typeof(FactionTrait));
			Serializer.Initialize(typeof(FactionTraitCategoryDefinition));
			Serializer.Initialize(typeof(FactionTraitStartingSenate));
			Serializer.Initialize(typeof(LesserFaction));
			Serializer.Initialize(typeof(MajorFaction));
			Serializer.Initialize(typeof(MinorFaction));
			Serializer.Initialize(typeof(PirateFaction));
			Serializer.Initialize(typeof(LocalizationDatatableElement));
		}

		public EntityContext() : base(ConnectionString)
		{
			Database.SetInitializer(new EntityInitializer());
		}


		public void ClearTables()
		{
			GetTables().ForEach(table => table.Clear());
		}


		public void SeedTables()
		{
			GetTables().ForEach(table => table.Add(table.Create()));
		}


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
