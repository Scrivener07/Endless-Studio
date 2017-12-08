using ES2.Editor.Model;
using System;

namespace ES2.Editor.Serialization
{
	/// <summary>
	/// Stores a type in the entity serializer.
	/// <code>[StudioTypeAttribute(typeof(MajorFaction))]</code>
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class GameTypeAttribute : Attribute
	{
		public GameTypeAttribute(Type type)
		{
			EntityType.Serializer.Store(type);
		}
	}
}
