using ES2.Editor;
using ES2.Editor.Framework;
using ES2.Editor.Model;
using Studio.Presentation;
using System;
using System.IO;
using System.Windows.Forms;

namespace Studio
{
	internal static class Program
	{
		public static StudioContext<MainForm> Studio { get; private set; }
		public static ProjectContext Game { get; private set; }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Game = new ProjectContext();
			Studio = new StudioContext<MainForm>(new MainForm());
			Application.Run(Studio);
		}

		/// <summary>
		/// Initializes the entity framework database and serializers.
		/// </summary>
		/// <returns></returns>
		public static bool Initialize()
		{
			Datatable.Initialize();
			using (var context = new EntityContext())
			{
				new EntityInitializer().InitializeDatabase(context);
				context.ClearTables();
				context.SaveChanges();
				context.LoadTables();
			}
			return true;
		}


	}
}
