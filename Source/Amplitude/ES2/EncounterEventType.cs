using System;
using System.CodeDom.Compiler;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum EncounterEventType
	{
		BattleStart,
		BattleEnd,
		PhaseStart,
		PhaseEnd,
		LastPhaseStart,
		Spawned,
		Attack_Preparation,
		Attack_Start,
		Attack_PrepareSalvoLaunched,
		Attack_SalvoLaunched,
		Attack_PostSalvoLaunched,
		Attack_HitShield,
		Attack_PrepareHitTarget,
		Attack_HitTarget,
		Attack_PostHitTarget,
		Attack_Miss,
		Attack_TargetLost,
		Attack_End,
		EnterArea,
		ExitArea,
		MedalGained,
		ComputeEndBattleStatus,
		Healing_Prepare,
		Healing,
		BattleFinalization,
		Deactivation,
		Destruction,
		DestructionComplete,
		Squadron_MatchCreated_Duel,
		Squadron_MatchCreated_Chase,
		Squadron_MatchCreated_Assault,
		Squadron_MatchImminent_Duel,
		Squadron_MatchImminent_Chase,
		Squadron_MatchImminent_Assault,
		Squadron_MatchAction_PrepareAttack,
		Squadron_MatchAction_Attack,
		Squadron_MatchAction_Hit,
		Squadron_MatchAction_PostAttack
	}
}
