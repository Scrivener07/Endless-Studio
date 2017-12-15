using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ES2.Editor.Model
{
	[NotMapped]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class EntityTypeMeta
	{
		/// <summary>
		/// The table that "owns" this entity.
		/// </summary>
		public Stack<Datatable> TableStack { get; set; }


		/// <summary>
		/// Preserves XML comments after deserialization.
		/// </summary>
		public BindingList<string> Comments { get; set; }


		public EntityTypeMeta()
		{
			TableStack = new Stack<Datatable>();
			Comments = new BindingList<string>();
		}


		public string GetTablePath()
		{
			return TableStack.Peek().Asset.FilePath;
		}


	}
}
