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
	public class QuestPodiumRewardDefinition : QuestRewardDefinition
	{
		private QuestRewardItemDefinition[] rewardField;

		private float minimumParticipationField;


		public QuestPodiumRewardDefinition()
		{
			this.minimumParticipationField = ((float)(-1F));
		}


		/// <remarks/>
		[XmlElement("Reward", Form = XmlSchemaForm.Unqualified)]
		public QuestRewardItemDefinition[] Reward
		{
			get { return this.rewardField; }
			set
			{
				this.rewardField = value;
				this.RaisePropertyChanged("Reward");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue(typeof(float), "-1")]
		public float MinimumParticipation
		{
			get { return this.minimumParticipationField; }
			set
			{
				this.minimumParticipationField = value;
				this.RaisePropertyChanged("MinimumParticipation");
			}
		}


	}
}
