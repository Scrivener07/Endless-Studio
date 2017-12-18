using ES2.Editor.Assets;
using System;

namespace ES2.Editor
{
	public class ProjectUpdatedEventArgs : EventArgs
	{
		public readonly ProjectState State;
		public readonly ModificationFile Current;


		public ProjectUpdatedEventArgs(ProjectState state, ModificationFile current)
		{
			State = state;
			Current = current;
		}
	}
}
