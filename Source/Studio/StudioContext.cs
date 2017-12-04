using Microsoft.Win32;
using Sharp.Applications;
using Sharp.Applications.Dialogs;
using Sharp.Applications.Storage;
using Sharp.Applications.Storage.Special;
using Studio.Presentation;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio.Framework
{
	public class StudioContext<T> : ClientContext<T> where T : Form, IClient
	{
		public AppDetails Details { get; private set; }
		public AppSettings Settings { get; private set; }
		//public ProjectModel Project { get; private set; }


		public StudioContext(T client) : base(client)
		{
			Details = new AppDetails("Studio")
			{
				Supported = new Version(1, 1, 58, 3),
				Version = new Version(0, 3, 1, 0)
			};

			Settings = new AppSettings();

			//Project = new ProjectModel();

			MainForm = new SplashWindow();
			Initialize();
		}


		private async void Initialize()
		{
			if (MainForm is ISplash)
			{
				var splash = MainForm as ISplash;
				splash.SetFade(true);
				splash.Title = "Studio";
				splash.PrimaryMessage = String.Concat("Studio v", Details.Version.ToString());
				splash.SecondaryMessage = String.Concat("Supports v", Details.Supported.ToString());

				if (await Task.Run(() => Program.Initialize()))
				{
					MainForm.Close();
				}
			}
		}


		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			if (sender is ISplash)
			{
				MainForm = Client;
				MainForm.Show();
			}
			else if (sender is T)
			{
				base.OnMainFormClosed(sender, e);
			}
		}


	}




	public class AppDetails
	{
		public string Name { get; set; }
		public Version Version { get; set; }
		public Version Supported { get; set; }

		public AppDetails(string name, Version application = null, Version supported = null)
		{
			Name = name;
			Version = application;
			Supported = supported;
		}
	}




	public class AppSettings
	{
		public AppFolder App { get; private set; }
		public GameFolder Game { get; private set; }
		public UserFolder User { get; private set; }


		public AppSettings()
		{
			App = new AppFolder();
			Game = new GameFolder();
			User = new UserFolder();
		}

	}


	public class AppFolder : FolderAsset
	{
		public string ContentDirectory { get { return Path.Combine(Location, "Content"); } }
		public ZipAsset ArchivePublic { get; private set; }
		public ZipAsset ArchivePublicXp { get; private set; }


		public AppFolder() : base(AutoDetect())
		{
			construct();
		}

		public AppFolder(string location) : base(location)
		{
			construct();
		}

		private void construct()
		{
			ArchivePublic = new ZipAsset(Path.Combine(ContentDirectory, "Public.zip"));
			ArchivePublicXp = new ZipAsset(Path.Combine(ContentDirectory, "Public_xp1.zip"));
		}


		public static string AutoDetect()
		{
			return Application.StartupPath;
		}

	}


	public class GameFolder : FolderAsset
	{
		public string Public { get { return Path.Combine(Location, "Public"); } }
		public string PublicXp { get { return Path.Combine(Location, "Public_xp1"); } }
		public string Data { get { return Path.Combine(Location, "EndlessSpace_Data"); } }

		public GameFolder() : base(AutoDetect()) { }
		public GameFolder(string location) : base(location) { }

		public static string AutoDetect()
		{
			RegistryKey key = Registry.CurrentUser;
			key = key.OpenSubKey("Software\\Valve\\Steam");
			if (key != null)
			{
				string value = key.GetValue("SteamPath").ToString();
				string result = Path.Combine(value, "SteamApps", "common", "Endless Space");
				return result;
			}
			return null;
		}

	}


	public class UserFolder : FolderAsset
	{
		public string Mods { get { return Path.Combine(Location, "Modding"); } }
		public string ModsXp { get { return Path.Combine(Location, "Disharmony", "Modding"); } }
		public string Editor { get { return Path.Combine(Location, "Editor"); } }

		public UserFolder() : base(AutoDetect()) { }
		public UserFolder(string location) : base(location) { }

		public static string AutoDetect()
		{
			string mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			return Path.Combine(mydocs, "Endless Space");
		}
	}
}