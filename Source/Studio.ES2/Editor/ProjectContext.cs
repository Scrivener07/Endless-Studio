using ES2.Editor.Assets;
using Sharp.Applications;
using System;
using System.IO;

namespace ES2.Editor
{
	public class ProjectContext : IProject
	{
		DataStore Data;

		public Version Supported { get; private set; }
		public AppFolder App { get; private set; }
		public SteamFolder Steam { get; private set; }
		public UserFolder User { get; private set; }


		public ProjectContext()
		{
			Supported = new Version(5, 5, 1, 7352351);
			App = new AppFolder();
			Steam = new SteamFolder();
			User = new UserFolder();
			Data = new DataStore(Path.Combine(User.Mods, "Vanilla"));
		}


		#region IProject

		public bool Open(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Allocate(progress) && Data.Import(progress);
		}


		/// <summary>
		/// Will allocate an existing modification from an index file.
		/// </summary>
		/// <param name="filepath">The path to an index file.</param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool Open(string filepath, IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Allocates a new modification at the provided directory.
		/// </summary>
		/// <param name="directory">The directory to create the modification.</param>
		/// <param name="progress"></param>
		/// <returns></returns>
		public bool New(string directory, IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException("Creating a new project is not implemented yet.");
		}


		/// <summary>
		/// Unloads any loaded project model.
		/// </summary>
		/// <returns></returns>
		public bool Unload()
		{
			throw new NotImplementedException("Unloading a project is not implemented yet.");
		}

		#endregion


		public bool Save(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Export(progress);
		}


	}
}