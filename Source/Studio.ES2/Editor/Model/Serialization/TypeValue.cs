using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace ES2.Editor.Model.Serialization
{
	public class TypeValue : IEquatable<TypeValue>
	{
		private readonly string Name;
		private readonly string NameKey;
		private readonly XmlSerializer Serializer;
		public string Key { get { return NameKey; } }


		public TypeValue(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type", "The argument cannot be null.");
			}
			else
			{
				Name = type.Name;
				NameKey = GetKeyName(type);
				Serializer = new XmlSerializer(type);
				if (Serializer == null) { throw new InvalidOperationException("Could not initialize serializer for the system type " + type.Name); }
				Trace.WriteLine("Created new type value of " + Name + " for xml serialization.");
			}
		}


		public void Serialize(XmlWriter xml, object o, XmlSerializerNamespaces namespaces)
		{
			Serialize(xml, o, namespaces);
		}


		public object Deserialize(XmlReader xml)
		{
			return Serializer.Deserialize(xml);
		}


		private static string GetKeyName(Type type)
		{
			Attribute[] attributes = Attribute.GetCustomAttributes(type);

			foreach (Attribute attribute in attributes)
			{
				if (attribute is XmlRootAttribute xmlRoot)
				{
					return xmlRoot.ElementName;
				}
				if (attribute is XmlTypeAttribute xmlType)
				{
					return xmlType.TypeName;
				}
			}
			return type.Name;
		}


		#region IEquatable<GameType>

		public bool Equals(TypeValue other)
		{
			if (other == null) return false;
			return (NameKey.Equals(other.NameKey));
		}


		/// <summary>Returns the hashcode for the types Name property.</summary>
		/// <returns>A hash code for the current types Name.</returns>
		public override int GetHashCode()
		{
			return NameKey.GetHashCode();
		}


		/// <summary>Override is needed to be able to use the same validation independent of the way of comparing.</summary>
		/// <returns>True if the specified <see cref="T:System.Object"></see> is a GameType object and its Name is the same as the current types Name; otherwise False;</returns>
		public override bool Equals(object obj)
		{
			if (obj != null && obj is TypeValue)
				return Equals((TypeValue)obj);
			else
				return false;
		}


		/// <summary>Checks if two types are the same.</summary>
		/// <param name="A">First type to compare with.</param>
		/// <param name="B">Second type to compare with.</param>
		/// <returns>True if the Name property for both types is the same; otherwise false.</returns>
		/// <remarks>Needed when working with value types.</remarks>
		public static bool operator ==(TypeValue A, TypeValue B)
		{
			if (ReferenceEquals(A, B)) return true;
			if (A is null) return false;
			if (B is null) return false;
			return A.Equals(B);
		}


		/// <summary>Checks if two types are different.</summary>
		/// <param name="A">First type to compare with.</param>
		/// <param name="B">Second type to compare with.</param>
		/// <returns>True if the Name property for both types are different; otherwise false.</returns>
		/// <remarks>Needed when working with value types.</remarks>
		public static bool operator !=(TypeValue A, TypeValue B)
		{
			if (ReferenceEquals(A, B)) return false;
			if (A is null) return true;
			if (B is null) return true;
			return !A.Equals(B);
		}

		#endregion


	}
}
