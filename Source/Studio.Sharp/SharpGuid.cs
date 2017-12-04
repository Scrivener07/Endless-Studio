using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Sharp
{
	public static class SharpGuid
	{
		/// <summary>
		/// 32 combined digits.
		/// ex. 00000000000000000000000000000000
		/// </summary>
		public const string Combined = "N";

		/// <summary>
		/// 32 digits separated by hyphens.
		/// ex. 00000000-0000-0000-0000-000000000000
		/// </summary>
		public const string Separated = "D";

		/// <summary>
		/// 32 digits separated by hyphens, enclosed in braces.
		/// ex. {00000000-0000-0000-0000-000000000000}
		/// </summary>
		public const string EnclosedBrace = "B";

		/// <summary>
		/// 32 digits separated by hyphens, enclosed in parentheses.
		/// ex. (00000000-0000-0000-0000-000000000000)
		/// </summary>
		public const string EnclosedParentheses = "P";

		/// <summary>
		/// Four hexadecimal values enclosed in braces, where the fourth value is a
		/// subset of eight hexadecimal values that is also enclosed in braces.
		/// ex. {0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}
		/// </summary>
		public const string Hexadecimal = "X";





		public static string Convert(this Guid guid)
		{
			return TypeDescriptor.GetConverter(guid).ConvertToInvariantString(guid);
		}


		public static Guid Convert(string identifier)
		{
			Guid guid = new Guid();
			if (TypeDescriptor.GetConverter(guid).IsValid(identifier))
			{
				guid = (Guid)TypeDescriptor.GetConverter(guid).ConvertFromString(identifier);
			}
			else
			{
				Trace.WriteLine("String ID: \"" + identifier + "\" is not valid! Conversion to GUID failed.");
			}

			return guid;
		}


		public static string ToFormat(this Guid guid, string format)
		{
			if (IsStrict(format))
			{
				return guid.ToString(format);
			}
			else
			{
				Trace.WriteLine("Failed to apply format '" + format + "'. Returning guid as string.");
				return guid.ToString();
			}
		}


		public static string ToUpper(this Guid guid)
		{
			return guid.ToString().ToUpperInvariant();
		}


		public static string ToLower(this Guid guid)
		{
			return guid.ToString().ToLowerInvariant();
		}


		/// <summary>
		/// Guid format codes. N, D, B, P, or X.
		/// Will determine if the passed in string format is a specific guid format.
		/// </summary>
		/// <param name="format">The format to verify.</param>
		/// <returns>Returns true if the passed in format is strict.</returns>
		private static bool IsStrict(string format)
		{
			bool valid =
				format == Combined ||
				format == Separated ||
				format == EnclosedBrace ||
				format == EnclosedParentheses ||
				format == Hexadecimal;

			if (String.IsNullOrEmpty(format) || !valid)
			{
				Trace.WriteLine("Format " + format + " has failed to evaluate as valid.");
				return false;
			}
			else
			{
				return true;
			}
		}


	}
}
