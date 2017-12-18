using Sharp.Reporting;
using System;
using System.Threading.Tasks;

namespace ES2.Editor
{
	public interface IDataStore
	{
		/// <summary>
		/// Allocates the files on disk for import.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		bool Allocate(IProgress<ProgressEventArgs> progress = null);
		Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null);

		/// <summary>
		/// Exports the database to xml assets on disk.
		/// </summary>
		/// <param name="progress">The asynchronous progress reporter.</param>
		/// <returns>Returns true on successful completion.</returns>
		bool Export(IProgress<ProgressEventArgs> progress = null);
		Task<bool> ExportAsync(IProgress<ProgressEventArgs> progress = null);
	}
}
