using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Simulation
{

	/// <remarks/>
	[XmlInclude(typeof(QuestExecutionTreeDecorator_EmpireEventOfEventConstructionProgressed))]
	[XmlInclude(typeof(QuestExecutionTreeDecorator_ConstructionProgressed))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class QuestExecutionTreeDecoratorOfEventConstructionProgressed : QuestExecutionTreeNode
	{

		private QuestExecutionTreeCondition[] itemsField;

		private QuestInitiatorFilter initiatorField;

		private int progressionIncrementField;

		private bool stopAtFirstFailedConditionField;

		public QuestExecutionTreeDecoratorOfEventConstructionProgressed()
		{
			this.initiatorField = QuestInitiatorFilter.AllEmpires;
			this.progressionIncrementField = 0;
			this.stopAtFirstFailedConditionField = false;
		}

		/// <remarks/>
		[XmlElement("Condition_AreEqual", typeof(QuestExecutionTreeCondition_AreVariablesEqual), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_BattleEndedWithShips", typeof(QuestExecutionTreeCondition_BattleEndedWithShips), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_BattleEnded_FleetDestroyed", typeof(QuestExecutionTreeCondition_BattleEnded_FleetDestroyed), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CheckDiplomaticAbility", typeof(QuestExecutionTreeCondition_CheckDiplomaticAbility), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CheckDiplomaticRelation", typeof(QuestExecutionTreeCondition_CheckDiplomaticRelation), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CheckInterpreter", typeof(QuestExecutionTreeCondition_CheckInterpreter), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CheckPath", typeof(QuestExecutionTreeCondition_CheckPath), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CheckSenateComposition", typeof(QuestExecutionTreeCondition_CheckSenateComposition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_CountSimulationObjectsWithTag", typeof(QuestExecutionTreeCondition_CountSimulationObjectsWithTag), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_DiplomaticContracts", typeof(QuestExecutionTreeCondition_DiplomaticContracts), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_ExplorationProgress", typeof(QuestExecutionTreeCondition_ExplorationProgress), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_FleetHasHero", typeof(QuestExecutionTreeCondition_FleetHasHero), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_FleetShipStats", typeof(QuestExecutionTreeCondition_FleetShipStats), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_FleetShipStatsOnNode", typeof(QuestExecutionTreeCondition_FleetShipStatsOnNode), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_GovernmentType", typeof(QuestExecutionTreeCondition_GovernmentType), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasDeposits", typeof(QuestExecutionTreeCondition_HasDeposits), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasFidsi", typeof(QuestExecutionTreeCondition_HasFidsi), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasFleets", typeof(QuestExecutionTreeCondition_HasFleets), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasGarrisonComposition", typeof(QuestExecutionTreeCondition_HasGarrisonComposition), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasHappiness", typeof(QuestExecutionTreeCondition_HasHappiness), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasHeroes", typeof(QuestExecutionTreeCondition_HasHeroes), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasLaws", typeof(QuestExecutionTreeCondition_HasLaws), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasManpower", typeof(QuestExecutionTreeCondition_HasManpower), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasPlanets", typeof(QuestExecutionTreeCondition_HasPlanets), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasPoliticsScore", typeof(QuestExecutionTreeCondition_HasPoliticsScore), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasPopulationAmount", typeof(QuestExecutionTreeCondition_HasPopulationAmount), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasPopulationDiversity", typeof(QuestExecutionTreeCondition_HasPopulationDiversity), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasPopulationSlots", typeof(QuestExecutionTreeCondition_HasPopulationSlots), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasResource", typeof(QuestExecutionTreeCondition_HasResource), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasSpecialNodes", typeof(QuestExecutionTreeCondition_HasSpecialNodes), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasSystemDefense", typeof(QuestExecutionTreeCondition_HasSystemDefense), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasSystems", typeof(QuestExecutionTreeCondition_HasSystems), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasTradeIncome", typeof(QuestExecutionTreeCondition_HasTradeIncome), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_HasTradeRoutes", typeof(QuestExecutionTreeCondition_HasTradeRoutes), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_IsFleetDockedOnNode", typeof(QuestExecutionTreeCondition_IsFleetDockedOnNode), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_IsProgressionComplete", typeof(QuestExecutionTreeCondition_IsProgressionComplete), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_IsSystemOwnedBy", typeof(QuestExecutionTreeCondition_IsSystemOwnedBy), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_IsVariableNotEmpty", typeof(QuestExecutionTreeCondition_IsVariableNotEmpty), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_ManpowerDistribution", typeof(QuestExecutionTreeCondition_ManpowerDistribution), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_MinorFactionRelationship", typeof(QuestExecutionTreeCondition_MinorFactionRelationship), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_Pressure", typeof(QuestExecutionTreeCondition_Pressure), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_ShipHasResource", typeof(QuestExecutionTreeCondition_ShipHasResourceCost), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_ShipStats", typeof(QuestExecutionTreeCondition_ShipStats), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_SystemsHaveFidsi", typeof(QuestExecutionTreeCondition_SystemsHaveFidsi), Form = XmlSchemaForm.Unqualified)]
		[XmlElement("Condition_TimerEnded", typeof(QuestExecutionTreeCondition_TimerEnded), Form = XmlSchemaForm.Unqualified)]
		public QuestExecutionTreeCondition[] Items
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
		[DefaultValue(QuestInitiatorFilter.AllEmpires)]
		public QuestInitiatorFilter Initiator
		{
			get
			{
				return this.initiatorField;
			}
			set
			{
				this.initiatorField = value;
				this.RaisePropertyChanged("Initiator");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(0)]
		public int ProgressionIncrement
		{
			get
			{
				return this.progressionIncrementField;
			}
			set
			{
				this.progressionIncrementField = value;
				this.RaisePropertyChanged("ProgressionIncrement");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(false)]
		public bool StopAtFirstFailedCondition
		{
			get
			{
				return this.stopAtFirstFailedConditionField;
			}
			set
			{
				this.stopAtFirstFailedConditionField = value;
				this.RaisePropertyChanged("StopAtFirstFailedCondition");
			}
		}
	}

}