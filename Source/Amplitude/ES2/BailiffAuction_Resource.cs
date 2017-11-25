using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public partial class BailiffAuction_Resource : BailiffAuctionOfAuctionItem_Resource
	{
		private Type typeField;
		private float maxPercentageField;


		[XmlAttribute]
		public Type Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[XmlAttribute]
		public float MaxPercentage
		{
			get { return this.maxPercentageField; }
			set
			{
				this.maxPercentageField = value;
				this.RaisePropertyChanged("MaxPercentage");
			}
		}
	}


	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	public enum Type
	{
		Common,
		Strategic,
		Luxury,
		Alias,
		Gameplay,
		LateCollect,
		SystemStrategic,
		SystemLuxury
	}
}
