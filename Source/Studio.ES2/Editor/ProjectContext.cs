using ES2.Editor.Assets;
using Sharp.Applications;
using System;

namespace ES2.Editor
{
	public class ProjectContext : IProject
	{
		public ProjectModule Project { get; private set; }
		public Version Supported { get; private set; }
		public AppFolder App { get; private set; }
		public GameFolder Game { get; private set; }
		public UserFolder User { get; private set; }


		public ProjectContext()
		{
			Supported = new Version(5, 5, 1, 7352351);
			App = new AppFolder();
			Game = new GameFolder();
			User = new UserFolder();
			Project = new ProjectModule(this);
		}




		#region IProject

		/// <summary>
		/// Will allocate an existing modification from an index file.
		/// </summary>
		/// <param name="filepath">The path to an index file.</param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool Open(string filepath, IProgress<ProgressEventArgs> progress = null)
		{
			return Project.Open(filepath, progress);
		}


		/// <summary>
		/// Allocates a new modification at the provided directory.
		/// </summary>
		/// <param name="directory">The directory to create the modification.</param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool New(string directory, IProgress<ProgressEventArgs> progress = null)
		{
			return Project.New(directory, progress);
		}


		/// <summary>
		/// Unloads any loaded project model.
		/// </summary>
		/// <returns></returns>
		public bool Unload()
		{
			return Project.Unload();
		}

		#endregion


	}
}