using System.Collections.Generic;
using System.Reflection;

namespace Sharp
{
	public static class SharpObject
	{
		public static List<string> GetPropertyNames(this object value)
		{
			List<string> names = new List<string>();
			PropertyInfo[] type = value.GetType().GetProperties();

			foreach (PropertyInfo property in type)
			{
				names.Add(property.Name);
			}
			return names;
		}


		public static bool HasMethod(this object value, string methodName)
		{
			if (value != null)
			{
				var type = value.GetType();

				if (type != null)
				{
					return type.GetMethod(methodName) != null;
				}
			}
			return false;
		}


		public static bool HasMember(this object value, string memberName)
		{
			if (value != null)
			{
				var type = value.GetType();

				if (type != null)
				{
					return type.GetMember(memberName) != null;
				}
			}
			return false;
		}


		public static object GetPropertyValue(this object value, string propertyName)
		{
			if (value.HasMember(propertyName))
			{
				if (value.GetType().GetProperty(propertyName) != null)
				{
					return value.GetType().GetProperty(propertyName).GetValue(value, null);
				}
			}
			return null;
		}


	}
}
