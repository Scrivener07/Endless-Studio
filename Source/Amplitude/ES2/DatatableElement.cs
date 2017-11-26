using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[XmlInclude(typeof(ContextualDiplomaticTermDefinition))]
	[XmlInclude(typeof(ConstellationOwnershipBonusDefinition))]
	[XmlInclude(typeof(GroundBattleViewerConfig))]
	[XmlInclude(typeof(GroundBattleUnitConfig))]
	[XmlInclude(typeof(GroundBattleTroopTypeConfig))]
	[XmlInclude(typeof(GroundBattleStrategyDefinition))]
	[XmlInclude(typeof(BattleEffect))]
	[XmlInclude(typeof(BattleEffect_EmpireReward_SpawnShips))]
	[XmlInclude(typeof(BattleEffect_EmpireReward_Resource))]
	[XmlInclude(typeof(BattleEffect_SetStatus))]
	[XmlInclude(typeof(BattleEffect_SetPropertyValue))]
	[XmlInclude(typeof(BattleEffect_ApplyDescriptor))]
	[XmlInclude(typeof(BattleAction))]
	[XmlInclude(typeof(ScienceConstructibleElement))]
	[XmlInclude(typeof(TechnologyStageDefinition))]
	[XmlInclude(typeof(TechnologyLinkDefinition))]
	[XmlInclude(typeof(InteractiveTechnologyLinkDefinition))]
	[XmlInclude(typeof(TechnologyHelperVariableDefinition))]
	[XmlInclude(typeof(TechnologyQuadrantDefinition))]
	[XmlInclude(typeof(ConstructionRefundDefinition))]
	[XmlInclude(typeof(GameSettingRestrictionDefinition))]
	[XmlInclude(typeof(ItemDefinition))]
	[XmlInclude(typeof(GameSettingDefinition))]
	[XmlInclude(typeof(WorldSettingDefinition))]
	[XmlInclude(typeof(GameStatisticDefinition))]
	[XmlInclude(typeof(InterpreterBasedGameStatisticDefinition))]
	[XmlInclude(typeof(Shot_EncounterEvent))]
	[XmlInclude(typeof(SystemSupervisorDefinition))]
	[XmlInclude(typeof(Shot))]
	[XmlInclude(typeof(SystemDiscoverySequenceDefinition))]
	[XmlInclude(typeof(SystemDefenseThreshold))]
	[XmlInclude(typeof(StarSystemNodeDefinition))]
	[XmlInclude(typeof(WarPointsRewardDefinition))]
	[XmlInclude(typeof(VictoryConditionDefinition))]
	[XmlInclude(typeof(AnomalyDefinition))]
	[XmlInclude(typeof(AnomalyReductionDefinition))]
	[XmlInclude(typeof(BailiffDefinition))]
	[XmlInclude(typeof(BasicFaction))]
	[XmlInclude(typeof(BridgeModule))]
	[XmlInclude(typeof(ConstructibleElement))]
	[XmlInclude(typeof(CostReduction))]
	[XmlInclude(typeof(DefenseModule))]
	[XmlInclude(typeof(DestructionModule))]
	[XmlInclude(typeof(Droplist))]
	[XmlInclude(typeof(Faction))]
	[XmlInclude(typeof(FactionAffinity))]
	[XmlInclude(typeof(FactionAffinityMapping))]
	[XmlInclude(typeof(FactionPopulationTrait))]
	[XmlInclude(typeof(FactionTrait))]
	[XmlInclude(typeof(FactionTraitCategoryDefinition))]
	[XmlInclude(typeof(FactionTraitStartingSenate))]
	[XmlInclude(typeof(GuiCursor))]
	[XmlInclude(typeof(GuiHighlightDefinition))]
	[XmlInclude(typeof(GuiPlanetStatsModifier))]
	[XmlInclude(typeof(GuiPlanetTypeBaseStats))]
	[XmlInclude(typeof(GuiResourcePropertySet))]
	[XmlInclude(typeof(HullDefinition))]
	[XmlInclude(typeof(LesserFaction))]
	[XmlInclude(typeof(LogisticsModule))]
	[XmlInclude(typeof(MajorFaction))]
	[XmlInclude(typeof(MinorFaction))]
	[XmlInclude(typeof(MinorFactionPersonalityDefinition))]
	[XmlInclude(typeof(Module))]
	[XmlInclude(typeof(MothershipModule))]
	[XmlInclude(typeof(PirateFaction))]
	[XmlInclude(typeof(PopulationCollectionBonusTrait))]
	[XmlInclude(typeof(PopulationModifiersTrait))]
	[XmlInclude(typeof(PopulationPoliticalTraitDefinition))]
	[XmlInclude(typeof(PopulationTrait))]
	[XmlInclude(typeof(Rank))]
	[XmlInclude(typeof(RankPattern))]
	[XmlInclude(typeof(SquadronModule))]
	[XmlInclude(typeof(SupportModule))]
	[XmlInclude(typeof(UnlockDatatableElement))]
	[XmlInclude(typeof(WeaponModule))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class DatatableElement : INotifyPropertyChanged
	{
		private string nameField;


		[XmlAttribute]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
