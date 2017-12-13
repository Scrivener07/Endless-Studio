using ES2.Editor.Model;
using System;

namespace ES2.Editor.Serialization
{
	/// <summary>
	/// Stores a type for the entity serializer.
	/// </summary>
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = true)]
	public sealed class TypeValueAttribute : Attribute
	{
		public TypeValueAttribute(Type type)
		{
			EntityType.Serializer.Initialize(type);
		}
	}
}
