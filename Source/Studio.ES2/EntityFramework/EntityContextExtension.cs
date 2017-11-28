using ES2.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;

namespace Studio.EntityFramework
{
	public static class EntityContextExtension
	{
		public const string ConnectionString = "DBConnectionString";



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
			List<DbSet> list = new List<DbSet>();
			list.Add(context.RuntimeModules);
			list.Add(context.RuntimePlugins);
			list.Add(context.Tags);
			//list.Add(context.AffinityMappings);
			//list.Add(context.Affinitys);
			//list.Add(context.AIParameters);
			//list.Add(context.AIStarSystemAssignations);
			//list.Add(context.AIWarDefinitions);
			//list.Add(context.Alterations);
			//list.Add(context.AnomalyEffects);
			//list.Add(context.AnomalyReductions);
			//list.Add(context.BailiffDistrainees);
			//list.Add(context.BattleCardFamilys);
			//list.Add(context.BattleCards);
			//list.Add(context.BattleSequences);
			//list.Add(context.BattleSequenceSubShips);
			//list.Add(context.CeaseFireTerms);
			//list.Add(context.ColonizationEvents);
			//list.Add(context.Colors);
			//list.Add(context.CooperationAgreementTerms);
			//list.Add(context.CreateAllianceTerms);
			//list.Add(context.DeclareWarTerms);
			//list.Add(context.DefenseModules);
			//list.Add(context.DiplomaticAttitudeCustomModifiers);
			//list.Add(context.DiplomaticAttitudes);
			//list.Add(context.DiplomaticAttitudeSimpleModifiers);
			//list.Add(context.DiplomaticBehaviors);
			//list.Add(context.DiplomaticStatuses);
			//list.Add(context.DustInstantaneousTerms);
			//list.Add(context.DustPerTurnTerms);
			//list.Add(context.Eliminations);
			//list.Add(context.EmpireImprovementColonizations);
			//list.Add(context.EmpireImprovements);
			//list.Add(context.ExplorationEvents);
			//list.Add(context.Factions);
			//list.Add(context.FleetSortings);
			//list.Add(context.FleetTargetings);
			//list.Add(context.Formations);
			//list.Add(context.GalaxyFXEvents);
			//list.Add(context.GameDifficultyFactors);
			//list.Add(context.GameIntroductions);
			//list.Add(context.GameSpeedFactors);
			//list.Add(context.GuiInfos);
			//list.Add(context.HeroAbilities);
			//list.Add(context.HeroClasses);
			//list.Add(context.HeroLevels);
			//list.Add(context.Heros);
			//list.Add(context.Hulls);
			//list.Add(context.InteractiveEventOptions);
			//list.Add(context.InteractiveEvents);
			//list.Add(context.InviteToAllianceTerms);
			//list.Add(context.LayeredMusics);
			//list.Add(context.LeaveAllianceTerms);
			//list.Add(context.LocalizationPairs);
			//list.Add(context.MoonSurveys);
			//list.Add(context.NarrativeEvents);
			//list.Add(context.OpenBordersTerms);
			//list.Add(context.PeaceTerms);
			//list.Add(context.Personalities);
			//list.Add(context.PirateDifficulties);
			//list.Add(context.PlanetColonizations);
			//list.Add(context.PlanetInfrastructures);
			//list.Add(context.PointDefenseModules);
			//list.Add(context.RandomEvents);
			//list.Add(context.RealizationStacks);
			//list.Add(context.Resources);
			//list.Add(context.ResourceTerms);
			//list.Add(context.ShipDesigns);
			//list.Add(context.ShipDesignTemplates);
			//list.Add(context.ShipLevels);
			//list.Add(context.Shots);
			//list.Add(context.SimulationObjectDescriptors);
			//list.Add(context.StarSystemEvacuation);
			//list.Add(context.StarSystemTerms);
			//list.Add(context.SubShipModules);
			//list.Add(context.SupportModules);
			//list.Add(context.SystemImprovements);
			//list.Add(context.SystemInfiniteImprovements);
			//list.Add(context.Technologies);
			//list.Add(context.TechnologyTerms);
			//list.Add(context.TerraFormations);
			//list.Add(context.TraitOccasionalEffects);
			//list.Add(context.Traits);
			//list.Add(context.TreatyDiagnostics);
			//list.Add(context.TroopsSpecialModules);
			//list.Add(context.Tutorials);
			//list.Add(context.UniquePlanets);
			//list.Add(context.Victories);
			//list.Add(context.WeaponModules);
			return list;
		}


	}
}
