using Sharp.Applications;
using Sharp.Applications.Dialogs;
using Studio.Presentation;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio
{
	public class StudioContext<T> : ClientContext<T> where T : Form, IClient
	{
		public string Name { get; set; }
		public Version Version { get; set; }

		public StudioContext(T client) : base(client)
		{
			Name = "Studio";
			Version = new Version(0, 3, 1, 0);
			MainForm = new MainSplash();
			Initialize();
		}


		private async void Initialize()
		{
			if (MainForm is ISplash)
			{
				var splash = MainForm as ISplash;
				splash.SetFade(true);
				splash.Title = "Studio";
				splash.PrimaryMessage = String.Concat("Studio v", Version.ToString());
				splash.SecondaryMessage = String.Concat("Supports v", Program.Game.Supported.ToString());

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
}