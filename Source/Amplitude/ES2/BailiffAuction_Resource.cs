using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using AmbiguousType = Amplitude.ES2.Types.BailiffAuction_Resource.Type;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class BailiffAuction_Resource : BailiffAuctionOfAuctionItem_Resource
	{
		private AmbiguousType typeField;
		private float maxPercentageField;


		[XmlAttribute]
		public AmbiguousType Type
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
}
