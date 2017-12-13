using ES2.Editor;
using ES2.Editor.Framework;
using Studio.Presentation;
using System;
using System.Data.Entity;
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
		/// Initializes the entity framework database context.
		/// </summary>
		/// <returns></returns>
		public static bool Initialize()
		{
			using (var context = new EntityContext())
			{
				new EntityInitializer().InitializeDatabase(context);
				context.ClearTables();
				context.SaveChanges();

				// TODO: I think this defeats the purpose of calling load?
				// Syntax wise, its better than writing out Load() for each dbset
				context.GetTables().ForEach(table => table.Load());
			}
			return true;
		}


	}
}
