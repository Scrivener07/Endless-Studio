﻿using ES2.Amplitude.Unity.Runtime;
using System.Data.Entity;

namespace Studio.Framework
{
	public class EntityContext : DbContext
	{
		public DbSet<RuntimeModule> RuntimeModules { get; set; }
		//public DbSet<RuntimePlugin> RuntimePlugins { get; set; }
		//public DbSet<Tags> Tags { get; set; }

		//public DbSet<QuestDefinition> QuestDefinitions { get; set; }
		//public DbSet<TutorialDefinition> TutorialDefinitions { get; set; }
		//public DbSet<BasicFaction> BasicFactions { get; set; }
		//public DbSet<Faction> Factions { get; set; }
		//public DbSet<FactionAffinity> FactionAffinitys { get; set; }
		//public DbSet<FactionAffinityMapping> FactionAffinityMappings { get; set; }
		//public DbSet<FactionPopulationTrait> FactionPopulationTraits { get; set; }
		//public DbSet<FactionTrait> FactionTraits { get; set; }
		//public DbSet<FactionTraitCategoryDefinition> FactionTraitCategoryDefinitions { get; set; }
		//public DbSet<FactionTraitStartingSenate> FactionTraitStartingSenates { get; set; }
		//public DbSet<LesserFaction> LesserFactions { get; set; }
		//public DbSet<MajorFaction> MajorFactions { get; set; }
		//public DbSet<MinorFaction> MinorFactions { get; set; }
		//public DbSet<PirateFaction> PirateFactions { get; set; }


		public EntityContext() : base(Extensions.ConnectionString)
		{
			Database.SetInitializer(new EntityInitializer());
		}

	}
}
