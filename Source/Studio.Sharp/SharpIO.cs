using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sharp
{
	public static class SharpIO
	{

		public static bool IsDirectoryEmpty(string directory)
		{
			if (String.IsNullOrWhiteSpace(directory))
			{
				return true;
			}
			return !Directory.EnumerateFileSystemEntries(directory).Any();
		}


		public static string GetDirectoryName(string directory)
		{
			if (!String.IsNullOrWhiteSpace(directory))
			{
				return new DirectoryInfo(directory).Name;
			}
			else
			{
				return String.Empty;
			}
		}


		private static string[] GetXmlFiles(string location)
		{
			if (Directory.Exists(location))
			{
				var extensions = new List<string> { ".xml" }; //should be argument list of file extensions to find.
				var files = Directory.GetFiles(location, "*.*", SearchOption.TopDirectoryOnly).Where(s => extensions.Any(e => s.EndsWith(e)));
				return files.ToArray();
			}
			return new string[0];
		}


	}
}
