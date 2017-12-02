using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{
	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasSpecialNodes))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasSystems))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasPlanets))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasFidsi))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_SystemsHaveFidsi))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_BattleEndedWithShips))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_IsSystemOwnedBy))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasPopulationAmount))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasPopulationDiversity))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasPopulationSlots))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasHappiness))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasSystemDefense))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasPoliticsScore))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasGarrisonComposition))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_FleetHasHero))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasResource))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasFleets))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_BattleEnded_FleetDestroyed))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_IsFleetDockedOnNode))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_MinorFactionRelationship))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_GovernmentType))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasLaws))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CheckSenateComposition))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CheckDiplomaticRelation))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_ShipStats))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasHeroes))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CheckDiplomaticAbility))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_Pressure))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_DiplomaticContracts))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_ManpowerDistribution))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasManpower))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_AreVariablesEqual))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_FleetShipStats))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_FleetShipStatsOnNode))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_ShipHasResourceCost))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasTradeIncome))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasTradeRoutes))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_HasDeposits))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_IsProgressionComplete))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CheckPath))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CheckInterpreter))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_TimerEnded))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_CountSimulationObjectsWithTag))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_IsVariableNotEmpty))]
	[XmlInclude(typeof(QuestExecutionTreeCondition_ExplorationProgress))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeCondition : QuestExecutionTreeNode
	{
		private bool invertedField;

		private bool isFailureConditionField;


		public QuestExecutionTreeCondition()
		{
			this.invertedField = false;
			this.isFailureConditionField = false;
		}


		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool Inverted
		{
			get { return this.invertedField; }
			set
			{
				this.invertedField = value;
				this.RaisePropertyChanged("Inverted");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool IsFailureCondition
		{
			get { return this.isFailureConditionField; }
			set
			{
				this.isFailureConditionField = value;
				this.RaisePropertyChanged("IsFailureCondition");
			}
		}


	}
}
