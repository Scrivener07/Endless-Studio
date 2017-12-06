using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestStartActionsDefinition : INotifyPropertyChanged
	{

		private QuestExecutionTreeAction[] itemsField;

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
		public QuestExecutionTreeAction[] Items
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