using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ES2.Editor.Model
{
	[ComplexType]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class TextData
	{
		[Key]
		public virtual string Id { get; set; }
		public string Text { get; set; }

		public TextData()
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}
