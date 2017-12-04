using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeController_Parallel))]
	[XmlInclude(typeof(QuestExecutionTreeController_Sequence))]
	[XmlInclude(typeof(QuestExecutionTreeController_Loop))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeController : QuestExecutionTreeNode
	{
		private QuestExecutionTreeNode[] itemsField;

		private QuestExecutionTreeResetPolicy resetPolicyField;


		public QuestExecutionTreeController()
		{
			this.resetPolicyField = QuestExecutionTreeResetPolicy.None;
		}


		/// <remarks/>
		[XmlElement("Action_AddExperienceToFleets", typeof(QuestExecutionTreeAction_AddExperienceToFleets), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_AddLevelsToHeroes", typeof(QuestExecutionTreeAction_AddLevelsToHeroes), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_AddQuestMarkers", typeof(QuestExecutionTreeAction_AddQuestMarker), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ApplyDescriptor", typeof(QuestExecutionTreeAction_ApplyDescriptor), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ApplyNodeEffect", typeof(QuestExecutionTreeAction_ApplyNodeEffect), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ApplyQuestEffect", typeof(QuestExecutionTreeAction_ApplyQuestEffect), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ApplyStarSystemDefinition", typeof(QuestExecutionTreeAction_ApplyStarSystemDefinition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_AssignHero", typeof(QuestExecutionTreeAction_AssignHero), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_AssimilateMinorEmpire", typeof(QuestExecutionTreeAction_AssimilateMinorEmpire), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_BuildMinigameTeam", typeof(QuestExecutionTreeAction_BuildMinigameTeam), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ChooseOutcome", typeof(QuestExecutionTreeAction_ChooseOutcome), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ClearForceGuiDisable", typeof(QuestExecutionTreeAction_ClearForceGuiDisable), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_ClearSilentNotifications", typeof(QuestExecutionTreeAction_ClearSilentNotifications), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_Colonize", typeof(QuestExecutionTreeAction_Colonize), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_CompetitiveQuestWarning", typeof(QuestExecutionTreeAction_CompetitiveQuestWarning), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_CopyVariable", typeof(QuestExecutionTreeAction_CopyVariable), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_CreateFleetMissions", typeof(QuestExecutionTreeAction_CreateFleetMission), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_DestroyFleets", typeof(QuestExecutionTreeAction_DestroyFleet), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_DestroyShip", typeof(QuestExecutionTreeAction_DestroyShip), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_EliminateEmpire", typeof(QuestExecutionTreeAction_EliminateEmpire), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_Fail", typeof(QuestExecutionTreeAction_Fail), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_HealFleets", typeof(QuestExecutionTreeAction_HealFleets), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_HighlightGui", typeof(QuestExecutionTreeAction_HighlightGui), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_LockTargets", typeof(QuestExecutionTreeAction_LockTargets), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_Message", typeof(QuestExecutionTreeAction_Message), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RefreshGameNodesVisibility", typeof(QuestExecutionTreeAction_RefreshGameNodesVisibility), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RefreshInterpretedVariable", typeof(QuestExecutionTreeAction_RefreshInterpretedVariable), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RegisterLesserName", typeof(QuestExecutionTreeAction_RegisterLesserName), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RemoveCuriosity", typeof(QuestExecutionTreeAction_RemoveCuriosity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RemoveNodeEffect", typeof(QuestExecutionTreeAction_RemoveNodeEffect), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RemoveQuestEffect", typeof(QuestExecutionTreeAction_RemoveQuestEffect), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RemoveQuestMarkers", typeof(QuestExecutionTreeAction_RemoveQuestMarker), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RenameSystem", typeof(QuestExecutionTreeAction_RenameSystem), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_RevealEntities", typeof(QuestExecutionTreeAction_RevealEntities), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetComparativeProgress", typeof(QuestExecutionTreeAction_SetComparativeProgress), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetForceGuiDisable", typeof(QuestExecutionTreeAction_SetForceGuiDisable), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetHappinessStatusSet", typeof(QuestExecutionTreeAction_SetHappinessStatusSet), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetInvisibility", typeof(QuestExecutionTreeAction_SetInvisibility), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetMinorRelationPoints", typeof(QuestExecutionTreeAction_SetMinorRelationPoints), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetNotificationSilent", typeof(QuestExecutionTreeAction_SetNotificationSilent), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetProgress", typeof(QuestExecutionTreeAction_SetProgress), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SetQuestVisibility", typeof(QuestExecutionTreeAction_SetQuestVisibility), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnAnomaly", typeof(QuestExecutionTreeAction_SpawnAnomaly), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnCuriosity", typeof(QuestExecutionTreeAction_SpawnCuriosity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnFleets", typeof(QuestExecutionTreeAction_SpawnFleet), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnHero", typeof(QuestExecutionTreeAction_SpawnHero), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnImprovement", typeof(QuestExecutionTreeAction_SpawnImprovement), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SpawnPopulation", typeof(QuestExecutionTreeAction_SpawnPopulation), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_StartMinigame", typeof(QuestExecutionTreeAction_StartMinigame), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_StartTimer", typeof(QuestExecutionTreeAction_StartTimer), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_SwitchEmpireFaction", typeof(QuestExecutionTreeAction_SwitchEmpireFaction), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_TransferLocalManpower", typeof(QuestExecutionTreeAction_TransferLocalManpower), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_TransferResource", typeof(QuestExecutionTreeAction_TransferResource), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_TriggerPopulationEvent", typeof(QuestExecutionTreeAction_TriggerPopulationEvent), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_TriggerTutorial", typeof(QuestExecutionTreeAction_TriggerTutorial), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_TruncateVariable", typeof(QuestExecutionTreeAction_TruncateVariable), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Action_UnlockTechnology", typeof(QuestExecutionTreeAction_UnlockTechnology), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_BattleEnded", typeof(QuestExecutionTreeDecorator_BattleEnded), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_BeginTurn", typeof(QuestExecutionTreeDecorator_BeginTurn), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ColonizedPlanet", typeof(QuestExecutionTreeDecorator_ColonizedPlanet), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ColonizedSystem", typeof(QuestExecutionTreeDecorator_ColonizedSystem), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ConstructionCancelled", typeof(QuestExecutionTreeDecorator_ConstructionCancelled), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ConstructionCompleted", typeof(QuestExecutionTreeDecorator_ConstructionCompleted), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ConstructionProgressed", typeof(QuestExecutionTreeDecorator_ConstructionProgressed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ConstructionQueued", typeof(QuestExecutionTreeDecorator_ConstructionQueued), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_CuriosityDiscovered", typeof(QuestExecutionTreeDecorator_CuriosityDiscovered), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_DiplomaticContractStateChanged", typeof(QuestExecutionTreeDecorator_DiplomaticContractStateChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_DiplomaticRelationChanged", typeof(QuestExecutionTreeDecorator_DiplomaticRelationChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ElectionActionApplied", typeof(QuestExecutionTreeDecorator_ElectionActionApplied), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_EntityCreated", typeof(QuestExecutionTreeDecorator_EntityCreated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ExploredNode", typeof(QuestExecutionTreeDecorator_ExploredNode), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_FleetDocked", typeof(QuestExecutionTreeDecorator_FleetDocked), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_FleetMoved", typeof(QuestExecutionTreeDecorator_FleetMoved), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_FleetShipCount", typeof(QuestExecutionTreeDecorator_FleetHasShipCount), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_FleetUsedPortal", typeof(QuestExecutionTreeDecorator_FleetUsedPortal), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_GovernmentChanged", typeof(QuestExecutionTreeDecorator_GovernmentChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_GuardNode", typeof(QuestExecutionTreeDecorator_GuardNode), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_HasTutorialKeys", typeof(QuestExecutionTreeDecorator_HasTutorialKeys), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_HeroAssigned", typeof(QuestExecutionTreeDecorator_HeroAssigned), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_HeroLevelUp", typeof(QuestExecutionTreeDecorator_HeroLevelUp), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_HeroRecruited", typeof(QuestExecutionTreeDecorator_HeroRecruited), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Intercept", typeof(QuestExecutionTreeDecorator_Intercept), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_InvadeSystem", typeof(QuestExecutionTreeDecorator_InvadeSystem), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_LawAbrogated", typeof(QuestExecutionTreeDecorator_LawAbrogated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_LawActivated", typeof(QuestExecutionTreeDecorator_LawActivated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_MinigameObjectiveSecured", typeof(QuestExecutionTreeDecoratorMinigameObjectiveSecured), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_MinigameWon", typeof(QuestExecutionTreeDecorator_MinigameWon), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_MinorEmpireIntegrated", typeof(QuestExecutionTreeDecorator_MinorEmpireIntegrated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_MinorFactionRelation", typeof(QuestExecutionTreeDecorator_MinorFactionRelation), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_MothershipAttached", typeof(QuestExecutionTreeDecorator_MothershipAttached), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_NameChanged", typeof(QuestExecutionTreeDecorator_NameChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_OutpostActionStarted", typeof(QuestExecutionTreeDecorator_OutpostActionStarted), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_OutpostCreated", typeof(QuestExecutionTreeDecorator_OutpostCreated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PlanetDestroyed", typeof(QuestExecutionTreeDecorator_PlanetDestroyed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PlanetTerraformed", typeof(QuestExecutionTreeDecorator_PlanetTerraformed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PopulationBoostApplied", typeof(QuestExecutionTreeDecorator_PopulationBoostApplied), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PopulationGained", typeof(QuestExecutionTreeDecorator_PopulationGained), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PopulationTransferredToSpaceport", typeof(QuestExecutionTreeDecorator_PopulationTransferredToSpaceport), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_PostEndTurn", typeof(QuestExecutionTreeDecorator_PostEndTurn), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ProbeLaunched", typeof(QuestExecutionTreeDecorator_ProbeLaunched), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_QuestEffectFinished", typeof(QuestExecutionTreeDecorator_QuestEffectFinished), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_QuestFinished", typeof(QuestExecutionTreeDecorator_QuestFinished), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_RecipeCreated", typeof(QuestExecutionTreeDecorator_RecipeCreated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ResearchQueued", typeof(QuestExecutionTreeDecorator_ResearchQueued), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipConstructed", typeof(QuestExecutionTreeDecorator_ShipConstructed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipDesignCreated", typeof(QuestExecutionTreeDecorator_ShipDesignCreated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipDestroyed", typeof(QuestExecutionTreeDecorator_ShipDestroyed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipDisbanded", typeof(QuestExecutionTreeDecorator_ShipDisbanded), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipHasModule", typeof(QuestExecutionTreeDecorator_ShipHasModule), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipIsInGarrison", typeof(QuestExecutionTreeDecorator_IsShipInGarrison), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_ShipLevelUp", typeof(QuestExecutionTreeDecorator_ShipLevelUp), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_SystemDecolonized", typeof(QuestExecutionTreeDecorator_SystemDecolonized), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_SystemGainedFromInfluence", typeof(QuestExecutionTreeDecorator_SystemGainedFromInfluence), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_SystemLevelChanged", typeof(QuestExecutionTreeDecorator_SystemLevelChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_TechnologyUnlocked", typeof(QuestExecutionTreeDecorator_TechnologyUnlocked), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_TimeBubbleCreated", typeof(QuestExecutionTreeDecorator_TimeBubbleCreated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_TutorialPageOpened", typeof(QuestExecutionTreeDecorator_TutorialPageOpened), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_BattleSetupElementSelected", typeof(QuestExecutionTreeDecorator_Tutorial_BattleSetupElementSelected), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_DisplayedTutorialChanged", typeof(QuestExecutionTreeDecorator_Tutorial_DisplayedTutorialChanged), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_ElectionStepValidated", typeof(QuestExecutionTreeDecorator_Tutorial_ElectionStepValidated), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_FleetsSelected", typeof(QuestExecutionTreeDecorator_Tutorial_FleetsSelected), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_IngredientSelectedForRecipe", typeof(QuestExecutionTreeDecorator_Tutorial_IngredientSelectedForRecipe), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_SimpleActionExecuted", typeof(QuestExecutionTreeDecorator_Tutorial_SimpleActionExecuted), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Tutorial_TechnologySelected", typeof(QuestExecutionTreeDecorator_Tutorial_TechnologySelected), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Decorator_Wait", typeof(QuestExecutionTreeDecorator_Wait), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Loop", typeof(QuestExecutionTreeController_Loop), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Parallel", typeof(QuestExecutionTreeController_Parallel), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Sequence", typeof(QuestExecutionTreeController_Sequence), Form = XmlSchemaForm.Unqualified)]
		public QuestExecutionTreeNode[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(QuestExecutionTreeResetPolicy.None)]
		public QuestExecutionTreeResetPolicy ResetPolicy
		{
			get
			{
				return this.resetPolicyField;
			}
			set
			{
				this.resetPolicyField = value;
				this.RaisePropertyChanged("ResetPolicy");
			}
		}


	}
}
