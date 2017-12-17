using Sharp.Reporting;
using System;
using System.Threading.Tasks;

namespace ES2.Editor
{
	public interface IDataStore
	{
		bool Allocate(IProgress<ProgressEventArgs> progress = null);
		Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null);

		bool Import(IProgress<ProgressEventArgs> progress = null);
		Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null);

		bool Export(IProgress<ProgressEventArgs> progress = null);
		Task<bool> ExportAsync(IProgress<ProgressEventArgs> progress = null);
	}
}
