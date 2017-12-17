using ES2.Editor.Assets;
using Sharp.Reporting;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace ES2.Editor
{
	public class ProjectContext : IProject, IDataStore
	{
		DataStore Data;

		[Description("The Endless Space 2 game version that is supported by the editor.")]
		public Version Supported { get; private set; }

		[Description("The Endless Space 2 game directory.")]
		public SteamFolder Steam { get; private set; }

		[Description("The windows user data directory used by Endless Space 2.")]
		public UserFolder User { get; private set; }


		public StudioFolder App { get; private set; }


		public ProjectContext()
		{
			Supported = new Version(5, 5, 1, 7352351);
			Steam = new SteamFolder();
			User = new UserFolder();
			App = new StudioFolder();
			Data = new DataStore(Path.Combine(User.Mods, "Vanilla"));
		}


		#region IProject

		public bool Open(IProgress<ProgressEventArgs> progress = null)
		{
			Report.Progress(progress, Report.Message("Allocating and importing the vanilla content."));
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
			throw new NotImplementedException("Opening a project is not implemented yet.");
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


		public bool Save(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Export(progress);
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


		#region IDataStore

		public bool Allocate(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Allocate(progress);
		}

		public async Task<bool> AllocateAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Data.AllocateAsync(progress);
		}

		public bool Import(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Import(progress);
		}

		public async Task<bool> ImportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Data.ImportAsync(progress);
		}

		public bool Export(IProgress<ProgressEventArgs> progress = null)
		{
			return Data.Export(progress);
		}

		public async Task<bool> ExportAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Data.ExportAsync(progress);
		}

		#endregion


	}
}
