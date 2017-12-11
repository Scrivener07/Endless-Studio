using Sharp.Reporting;
using System;

namespace ES2.Editor
{
	public interface IProject
	{
		bool Open(IProgress<ProgressEventArgs> progress = null);
		bool Open(string filepath, IProgress<ProgressEventArgs> progress = null);
		bool New(string directory, IProgress<ProgressEventArgs> progress = null);
		bool Save(IProgress<ProgressEventArgs> progress = null);
		bool Unload();
	}
}
