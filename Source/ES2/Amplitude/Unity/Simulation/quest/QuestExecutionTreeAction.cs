using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeAction_ChooseOutcome))]
	[XmlInclude(typeof(QuestExecutionTreeAction_AddQuestMarker))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RemoveQuestMarker))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RefreshInterpretedVariable))]
	[XmlInclude(typeof(QuestExecutionTreeAction_Fail))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnFleet))]
	[XmlInclude(typeof(QuestExecutionTreeAction_DestroyFleet))]
	[XmlInclude(typeof(QuestExecutionTreeAction_DestroyShip))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnPopulation))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnCuriosity))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ApplyQuestEffect))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RemoveQuestEffect))]
	[XmlInclude(typeof(QuestExecutionTreeAction_TransferResource))]
	[XmlInclude(typeof(QuestExecutionTreeAction_Message))]
	[XmlInclude(typeof(QuestExecutionTreeAction_EliminateEmpire))]
	[XmlInclude(typeof(QuestExecutionTreeAction_UnlockTechnology))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RemoveCuriosity))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ApplyDescriptor))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetProgress))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnHero))]
	[XmlInclude(typeof(QuestExecutionTreeAction_HealFleets))]
	[XmlInclude(typeof(QuestExecutionTreeAction_AddExperienceToFleets))]
	[XmlInclude(typeof(QuestExecutionTreeAction_TriggerPopulationEvent))]
	[XmlInclude(typeof(QuestExecutionTreeAction_CreateFleetMission))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RevealEntities))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnAnomaly))]
	[XmlInclude(typeof(QuestExecutionTreeAction_AssignHero))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RefreshGameNodesVisibility))]
	[XmlInclude(typeof(QuestExecutionTreeAction_TriggerTutorial))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetForceGuiDisable))]
	[XmlInclude(typeof(QuestExecutionTreeAction_HighlightGui))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetNotificationSilent))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ClearForceGuiDisable))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ClearSilentNotifications))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetQuestVisibility))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RegisterLesserName))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SpawnImprovement))]
	[XmlInclude(typeof(QuestExecutionTreeAction_AssimilateMinorEmpire))]
	[XmlInclude(typeof(QuestExecutionTreeAction_Colonize))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetInvisibility))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetMinorRelationPoints))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RenameSystem))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ApplyStarSystemDefinition))]
	[XmlInclude(typeof(QuestExecutionTreeAction_LockTargets))]
	[XmlInclude(typeof(QuestExecutionTreeAction_CopyVariable))]
	[XmlInclude(typeof(QuestExecutionTreeAction_TruncateVariable))]
	[XmlInclude(typeof(QuestExecutionTreeAction_TransferLocalManpower))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetHappinessStatusSet))]
	[XmlInclude(typeof(QuestExecutionTreeAction_StartMinigame))]
	[XmlInclude(typeof(QuestExecutionTreeAction_BuildMinigameTeam))]
	[XmlInclude(typeof(QuestExecutionTreeAction_StartTimer))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SetComparativeProgress))]
	[XmlInclude(typeof(QuestExecutionTreeAction_CompetitiveQuestWarning))]
	[XmlInclude(typeof(QuestExecutionTreeAction_SwitchEmpireFaction))]
	[XmlInclude(typeof(QuestExecutionTreeAction_AddLevelsToHeroes))]
	[XmlInclude(typeof(QuestExecutionTreeAction_ApplyNodeEffect))]
	[XmlInclude(typeof(QuestExecutionTreeAction_RemoveNodeEffect))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeAction : QuestExecutionTreeNode
	{
		private bool logActionField;

		private string localizationKeyField;

		private string contextLocalizationKeyField;


		public QuestExecutionTreeAction()
		{
			this.logActionField = false;
			this.localizationKeyField = "";
			this.contextLocalizationKeyField = "";
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool LogAction
		{
			get { return this.logActionField; }
			set
			{
				this.logActionField = value;
				this.RaisePropertyChanged("LogAction");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string LocalizationKey
		{
			get { return this.localizationKeyField; }
			set
			{
				this.localizationKeyField = value;
				this.RaisePropertyChanged("LocalizationKey");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("")]
		public string ContextLocalizationKey
		{
			get { return this.contextLocalizationKeyField; }
			set
			{
				this.contextLocalizationKeyField = value;
				this.RaisePropertyChanged("ContextLocalizationKey");
			}
		}


	}
}
