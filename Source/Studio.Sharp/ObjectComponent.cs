using System;
using System.ComponentModel;

namespace Sharp
{
	/// <summary>
	/// Classes which inherit ObjectComponent<T> act as components of the parameter type.
	/// </summary>
	/// <typeparam name="T">The type which is the owner.</typeparam>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class ObjectComponent<T> where T : class
	{
		protected readonly T Owner;


		public ObjectComponent(T owner)
		{
			if (owner == null)
			{
				string message = string.Format("Cannot initialize '{0}' with null '{1}'.", this.GetType().Name, owner.GetType().Name);
				throw new ArgumentNullException("owner", message);
			}
			Owner = owner;
		}

	}
}
