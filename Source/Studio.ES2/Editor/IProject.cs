using Sharp.Applications;
using System;

namespace ES2.Editor
{
	public interface IProject
	{
		bool Open(string filepath, IProgress<ProgressEventArgs> progress = null);
		bool New(string directory, IProgress<ProgressEventArgs> progress = null);
		bool Unload();
	}
}
