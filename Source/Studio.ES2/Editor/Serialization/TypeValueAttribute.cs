using ES2.Editor.Framework;
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
			EntityContext.Serializer.Initialize(type);
		}
	}
}
