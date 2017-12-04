using System;

namespace Sharp
{
	public static class SharpString
	{
		public static string RemoveSpaces(this string value)
		{
			value = value.Trim();
			value = value.Replace(" ", null);
			return value;
		}


		public static bool Contains(this string value, string text, StringComparison comparison)
		{
			return value.IndexOf(text, comparison) >= 0;
		}

	}
}
