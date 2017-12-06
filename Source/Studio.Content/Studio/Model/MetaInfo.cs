using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studio.Model
{
	[ComplexType]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class MetaInfo
	{
		public string Mod { get; set; }
		public string File { get; set; }



		public MetaInfo()
		{
			Mod = String.Empty;
			File = String.Empty;
		}


		public override string ToString()
		{
			return Mod;
		}
	}
}
