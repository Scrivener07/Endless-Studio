using Sharp.Reporting;
using System;
using System.Threading.Tasks;

namespace ES2.Editor
{
	public interface IDatabase
	{
		/// <summary>
		/// Imports assets into the database.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		bool Import(IProgress<ProgressEventArgs> progress = null);
		Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null);
	}
}
