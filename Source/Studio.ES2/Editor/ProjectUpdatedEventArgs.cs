using ES2.Editor.Assets;
using System;

namespace ES2.Editor
{
	public class ProjectUpdatedEventArgs : EventArgs
	{
		public readonly ProjectState State;
		public readonly ModificationAsset Current;


		public ProjectUpdatedEventArgs(ProjectState state, ModificationAsset current)
		{
			State = state;
			Current = current;
		}
	}
}
